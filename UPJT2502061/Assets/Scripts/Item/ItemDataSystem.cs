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
        // �� ������� ����� ����� ����Ƽ �ν����Ϳ��� ������ �ʽ��ϴ�.
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
        //loadButton.interactable = interactable; // interactable �� ��ư ��Ȱ��ȭ Ȱ��ȭ ���
        
    }

    // 1. public���� ���� �Լ��� ����Ƽ �ν����Ϳ��� ���� ����
    // 2. public�� �ƴ� �Լ��� ��ũ��Ʈ �ڵ带 ���� ����� ����

    public void Sample()
    {
        Debug.Log("INPUT FIELD's ON VALUE CHANGED");
    }


    /// <summary>
    /// �۾��� ������ �Ǿ��� �� �ش� ������ �Է������� �˷��ִ� �Լ�
    /// </summary>
    /// <param name="text"></param>
    void ValueChanged(string text)
    {
        Debug.Log($"{text} �Է� �߽��ϴ�.");
    }

    private void SaveButtonClick()
    {
        string name = nameInputField.text;
        string description = descriptionNameField.text;

        nameText.text = name;
        descriptionText.text = description;

        PlayerPrefs.SetString(NameKey, name);
        PlayerPrefs.SetString(DescriptionKey, description);
        PlayerPrefs.Save(); // ������ ����

        Debug.Log("������ ���� �Ϸ�!");

        loadButton.interactable = PlayerPrefs.HasKey(NameKey) && PlayerPrefs.HasKey(DescriptionKey);
    }

    private void LoadButtonClick()
    {
        if (PlayerPrefs.HasKey(NameKey) && PlayerPrefs.HasKey(DescriptionKey))
        {
            nameInputField.text = PlayerPrefs.GetString(NameKey);
            descriptionNameField.text = PlayerPrefs.GetString(DescriptionKey);
            Debug.Log("������ �ҷ����� �Ϸ�!");
        }
        else
        {
            Debug.Log("����� �����Ͱ� �����ϴ�.");
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

            Debug.Log("������ ���� �Ϸ�!");
        }
        else
        {
            Debug.Log("������ �����Ͱ� �����ϴ�.");
        }

        loadButton.interactable = PlayerPrefs.HasKey(NameKey) && PlayerPrefs.HasKey(DescriptionKey);
    }
}
