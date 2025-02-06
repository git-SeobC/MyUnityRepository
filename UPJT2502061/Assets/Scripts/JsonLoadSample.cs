using System.IO;
using UnityEngine;
// How to use Json file
// 1. 읽을 수 있는 데이터 형태로 만들어줍니다.
// 2. 파일 경로 기반으로 json 파일을 찾아서 내부의 텍스트를 읽어냅니다.
// 3. 읽어낸 데이터를 통해 클래스화를 진행합니다.
// 4. 마음껏 쓰시면 됩니다.

[System.Serializable]
public class Item01
{
    public string name;
    public string description;
}

public class JsonLoadSample : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        string load_json = File.ReadAllText(Application.dataPath + "/item01.json");
        var data = JsonUtility.FromJson<Item01>(load_json);
        Debug.Log(data.name);

        data.name = "마음대로 바꿔보기";
        data.description = "딥시크 정보수집 중 엔비디아 떡상 가자";

        // Json 파일로 내보내기(data save)
        File.WriteAllText(Application.dataPath + "/item02.json", JsonUtility.ToJson(data));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
