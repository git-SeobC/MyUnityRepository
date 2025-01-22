using System;
using UnityEngine;



[AddComponentMenu("Borninileum/Sample01")]
public class Sample01 : MonoBehaviour
{
    public bool jumpAble;
    public string[] basket;
    public int money;
    [Range(1.0f, 99)] public float FieldofView;
    public RAINBOW rainbow;

    public enum RAINBOW
    {
        RED = 0,
        ORANGE = 1 << 1,
        YELLOW = 1 << 2,
        GREEN = 1 << 3,
        BLUE = 1 << 4,
        INDIGO = 1 << 5,
        VIOLET = 1 << 6
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
