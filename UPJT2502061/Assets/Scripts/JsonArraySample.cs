using System;
using System.Collections.Generic;
using TreeEditor;
using UnityEngine;
// 1. 배열 / List 형태로 저장되어있는 json 파일을 사용하는 예제
// 2. Resources 폴더를 이용한 데이터 로드 방법을 사용합니다.

[Serializable]
public class Item
{
    public string item_name; // json 파일에서 사용하고 있는 이름을 그대로 사용합니다.
    public int item_count;
}

[Serializable]
public class Inventory
{
    public List<Item> inventory; // json 파일에서 사용하고 있는 이름을 그대로 사용합니다.
    // == public Item[] inventory; 유니티에서는 배열과 리스트는 같은 취급
}

public class JsonArraySample : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        TextAsset textAsset = Resources.Load<TextAsset>("item_inventory");
        Inventory inventory = JsonUtility.FromJson<Inventory>(textAsset.text);

        int total = 0;

        //foreach 배열쓰기
        foreach (Item item in inventory.inventory)
        {
            total += item.item_count;
        }
        Debug.Log(total);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
