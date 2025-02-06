using System;
using System.Collections.Generic;
using TreeEditor;
using UnityEngine;
// 1. �迭 / List ���·� ����Ǿ��ִ� json ������ ����ϴ� ����
// 2. Resources ������ �̿��� ������ �ε� ����� ����մϴ�.

[Serializable]
public class Item
{
    public string item_name; // json ���Ͽ��� ����ϰ� �ִ� �̸��� �״�� ����մϴ�.
    public int item_count;
}

[Serializable]
public class Inventory
{
    public List<Item> inventory; // json ���Ͽ��� ����ϰ� �ִ� �̸��� �״�� ����մϴ�.
    // == public Item[] inventory; ����Ƽ������ �迭�� ����Ʈ�� ���� ���
}

public class JsonArraySample : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        TextAsset textAsset = Resources.Load<TextAsset>("item_inventory");
        Inventory inventory = JsonUtility.FromJson<Inventory>(textAsset.text);

        int total = 0;

        //foreach �迭����
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
