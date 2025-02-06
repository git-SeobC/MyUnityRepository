using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ItemDataSystem : MonoBehaviour
{

    [Header("====")]
    public TMP_InputField nameInputField;
    public TMP_InputField descriptionNameField;
    [Header("====")]
    public TMP_Text nameText;
    public TMP_Text descriptionText;
    [Header("====")]
    public Button saveButton;
    public Button loadButton;
    public Button deleteButton;

    public bool interactable;

    private const string NameKey = "TestName";
    private const string DescriptionKey = "TestDescription";

    void Start()
    {
        nameInputField.onEndEdit.AddListener(ValueChanged);
        // 이 방식으로 등록한 기능은 유니티 인스펙터에서 보이지 않습니다.
        descriptionNameField.onEndEdit.AddListener(ValueChanged);

        //saveButton = GameObject.Find("SaveButton").GetComponent<Button>();
        //loadButton = GameObject.Find("LoadButton").GetComponent<Button>();
        //deleteButton = GameObject.Find("DeleteButton").GetComponent<Button>();

        saveButton.onClick.AddListener(SaveButtonClick);
        loadButton.onClick.AddListener(LoadButtonClick);
        deleteButton.onClick.AddListener(DeleteButtonClick);

        loadButton.interactable = PlayerPrefs.HasKey(NameKey) && PlayerPrefs.HasKey(DescriptionKey);
    }

    private void Update()
    {
        //loadButton.interactable = interactable; // interactable 은 버튼 비활성화 활성화 기능
        
    }

    // 1. public으로 만든 함수는 유니티 인스펙터에서 직접 연결
    // 2. public이 아닌 함수는 스크립트 코드를 통해 기능을 연결

    public void Sample()
    {
        Debug.Log("INPUT FIELD's ON VALUE CHANGED");
    }


    /// <summary>
    /// 작업이 마무리 되었을 때 해당 문구를 입력했음을 알려주는 함수
    /// </summary>
    /// <param name="text"></param>
    void ValueChanged(string text)
    {
        Debug.Log($"{text} 입력 했습니다.");
    }

    private void SaveButtonClick()
    {
        string name = nameInputField.text;
        string description = descriptionNameField.text;

        nameText.text = name;
        descriptionText.text = description;

        PlayerPrefs.SetString(NameKey, name);
        PlayerPrefs.SetString(DescriptionKey, description);
        PlayerPrefs.Save(); // 데이터 저장

        Debug.Log("데이터 저장 완료!");

        loadButton.interactable = PlayerPrefs.HasKey(NameKey) && PlayerPrefs.HasKey(DescriptionKey);
    }

    private void LoadButtonClick()
    {
        if (PlayerPrefs.HasKey(NameKey) && PlayerPrefs.HasKey(DescriptionKey))
        {
            nameInputField.text = PlayerPrefs.GetString(NameKey);
            descriptionNameField.text = PlayerPrefs.GetString(DescriptionKey);
            Debug.Log("데이터 불러오기 완료!");
        }
        else
        {
            Debug.Log("저장된 데이터가 없습니다.");
        }
    }

    private void DeleteButtonClick()
    {
        if (PlayerPrefs.HasKey(NameKey) || PlayerPrefs.HasKey(DescriptionKey))
        {
            PlayerPrefs.DeleteKey(NameKey);
            PlayerPrefs.DeleteKey(DescriptionKey);
            PlayerPrefs.Save();

            nameInputField.text = "";
            descriptionNameField.text = "";
            nameText.text = "";
            descriptionText.text = "";

            Debug.Log("데이터 삭제 완료!");
        }
        else
        {
            Debug.Log("삭제할 데이터가 없습니다.");
        }

        loadButton.interactable = PlayerPrefs.HasKey(NameKey) && PlayerPrefs.HasKey(DescriptionKey);
    }
}
