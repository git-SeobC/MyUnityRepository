﻿using System;
using UnityEngine;
// 플레이어의 이동(리지드바디) -> 물리적 계산식 이동, Transform으로의 이동 X

// 해당 기능을 통해 이 스크립트를 컴포턴트로써 사용할 경우
// 적어놓은 컴포넌트를 요구하게 됩니다.
// 1. 해당 컴포넌트가 없는 오브젝트에 연결할 경우 자동으로 연결을 진행
// 2. 이 스크립트가 연결된 상태라면 그 오브젝트는 대상의 컴포넌트를 제거할 수 없음
[RequireComponent(typeof(Rigidbody2D))] // 필수 컴포넌트의 경우 삭제 방지를 위함, 없는 오브젝트에 스크립트 추가시 해당 컴포넌트 자동으로 추가
public class PlayerMovement : MonoBehaviour
{
    //public int a = 10;
    public float speed = 2.0f; // 소수점을 적을 때는 마지막에 'f'를 사용
    // 소수점 약 6자리까지 정확하게 계산
    public double jump_force = 3.5; // double도 실수를 표현하는 자료형, 'f'를 붙이지 않음
    // 소수점 약 15자리까지 정확하게 계산

    public bool isjump = false;

    private Rigidbody2D rigid;

    private GameObject player;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rigid = GetComponent<Rigidbody2D>();
        // GetComponent<T> => 해당 컴포넌트가 값을 얻어오는 기능
        // T 부분에는 컴포넌트의 형태를 작성해줍니다. 컴포넌트의 형태가 다르다면 오류 발생
        // 해당 데이터가 존재하지 않을 경우라면 null을 반환하게 됩니다.
        player = this.gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        Jump();

    }

    private void Move()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxisRaw("Vertical");
        // GetAxisRaw("키 명"); 은 인풋 매니저의 키를 얻어오면서
        // 클릭에 따라 -1, 0 , 1의 수치로 값을 얻어옵니다.

        // Horizontal : 수평 이동 a, d 키나 키보드의 왼쪽, 오른쪽 키
        // Vertical : 수직 이동 w, s 키나 키보드의 위, 아래 키

        // 위의 코드를 통해 움직일 방향을 계산합니다.
        Vector3 velocity = new Vector3(x, y, 0) * speed * Time.deltaTime;
        // 속력 = 방향 * 속도

        transform.position += velocity;

    }

    private void Jump()
    {
        // 사용자가 키보드 Space 키를 입력한다면
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (!isjump) // 점프 상태가 아닌 경우
            {
                isjump = true; // 점프 상태로 변경
                rigid.AddForce(Vector3.up * (float)jump_force, ForceMode2D.Impulse); // 유니티 코드 대부분 float이기 때문에 double은 잘 안씀
                // type casting
                // "(타입 이름)변수" 를 통해 해당 변수를 설정한 타입으로 변경할 수 있습니다.
                // 단 캐스팅이 가능한 범위에서만 진행할 수 있습니다.
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // 충돌체의 게임 오브젝트의 레이어가 7과 비교했을 때 크기가 같다면
        //if (collision.gameObject.layer == 7)
        if (LayerMask.LayerToName(collision.gameObject.layer) == "Ground")
        {
            isjump = false;
        }
        Debug.Log("땅을 밟았습니다!");
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Finish")
        {
            Debug.Log("골인!!");
        }

        if (LayerMask.LayerToName(collision.gameObject.layer) == "Water")
        {
            Destroy(player, 0);
            Debug.Log("Game Over");
        }
    }
}
