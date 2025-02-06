using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class SampleData
{
    public int i;
    public float f;
    public bool b;
    public Vector3 v;
    public string s;
    public int[] iarra;
}

public class JsonExample : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        SampleData sample = new SampleData();
        sample.i = 0;
        sample.iarra = new int[] {1,2,3,4};
        sample.b = true;
        sample.f = 1.0f;
        sample.v = Vector3.zero;
        sample.s = "hhttpp";

        // SampleData 클래스를 통해 만든 json 파일(string)
        string json_data = JsonUtility.ToJson(sample);
        Debug.Log(json_data);

        // json_data를 통해 전달받은 값으로 만든 sample2 오브젝트
        var sample2 = JsonUtility.FromJson<SampleData>(json_data);
        Debug.Log(sample2.s);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
