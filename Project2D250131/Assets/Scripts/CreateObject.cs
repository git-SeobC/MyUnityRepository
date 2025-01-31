﻿using UnityEngine;

public class CreateObject : MonoBehaviour
{

    public GameObject prefab;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // 등록해놓은 프리팹 그대로 생성, 일반 생성하는 경우는 거의 없음
        Instantiate(prefab);
        // 생성 기능 Instantiate()

        // 등록해놓은 프리팹과 위치와 회전 설정을 다 진행해 생성을 진행.
        Instantiate(prefab, new Vector3(0,0,0), Quaternion.identity);
        // Vector3 : 방향과 크기를 설명하는 개념, 캐릭터의 position, 오브젝트의 이동속도, 오브젝트 간의 거리 등을 사용할 때 사용하는 클래스
        // 2D -> Vector2 (x,y)
        // 3D -> Vector3 (x,y,z)

        // Quaternion : 게임 오브젝트의 3차원 방향을 저장, 한 방향에서 다른 방향으로의 상대적인 회전 값
        // 방향과 회전을 다 표현할 수 있는 클래스
        // 180도 보다 큰 값에 대한 표현은 할 수 없음.
        // Quaternion.identity = 회전 값 0

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
