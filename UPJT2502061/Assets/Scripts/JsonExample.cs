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

        // SampleData Ŭ������ ���� ���� json ����(string)
        string json_data = JsonUtility.ToJson(sample);
        Debug.Log(json_data);

        // json_data�� ���� ���޹��� ������ ���� sample2 ������Ʈ
        var sample2 = JsonUtility.FromJson<SampleData>(json_data);
        Debug.Log(sample2.s);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
