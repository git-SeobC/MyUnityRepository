﻿using UnityEngine;

public class CreateObject2 : MonoBehaviour
{
    public GameObject prefab;

    private GameObject square;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        square = Instantiate(prefab);

        Destroy(square, 5.0f); // 5초 뒤에 파괴.
        Debug.Log("파괴되었습니다"); // 파괴 모션을 기대하였으나, 그냥 뿅하고 없어짐.
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
