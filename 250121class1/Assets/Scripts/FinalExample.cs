using System;
using UnityEngine;

// 5. 무지개
[Flags]
public enum RAINBOW
{
    None = 0,
    RED = 1 << 0,
    ORANGE = 1 << 1,
    YELLOW = 1 << 2,
    GREEN = 1 << 3,
    BLUE = 1 << 4,
    DARKBLUE = 1 << 5,
    PUPPLE = 1 << 6
}

[AddComponentMenu("Boninileum/Finalexample")]
public class FinalExample : MonoBehaviour
{
    // 1. 점프가능 여부
    public bool isAbleToJump = true;
    // 2. 과일바구니
    [Header("과일바구니")]
    public string[] fruit_Basket;
    // 3. 돈
    [Header("돈")]
    public int cash;
    // 4. 필드 뷰 (Range(1,99))
    [Range(1, 99)]
    public int field_Of_View;

    public RAINBOW rainbow;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log(isAbleToJump);
        for (int i = 0; i < fruit_Basket.Length; i++)
        {
            Debug.Log(fruit_Basket[i]);
        }
        Debug.Log(cash);
        Debug.Log(field_Of_View);
        Debug.Log(rainbow);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
