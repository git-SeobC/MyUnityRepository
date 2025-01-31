using UnityEngine;
using System.Threading;
using TMPro;

public class CircleMove : MonoBehaviour
{
    //Circle을 지정된 위치로 Lerp 시키는 스크립트
    public GameObject Circle;
    Vector3 pos = new Vector3(5, -3, 0);

    public Vector3 pos1 = new Vector3(-5, 2, 0);  // 첫 번째 목표 위치
    public Vector3 pos2 = new Vector3(5, 1, 0);   // 두 번째 목표 위치
    public float moveSpeed = 0.025f;  // 이동 속도

    private Vector3 targetPosition;

    private void Start()
    {
        targetPosition = pos1;
    }

    // Update is called once per frame
    void Update()
    {

        //Circle.transform.position = Vector3.Lerp(Circle.transform.position, pos, Time.deltaTime);
        // 0을 입력할 경우 움직이지 않고, 1이 최대치

        // 일정한 속도로 목표 지점까지 이동하게 만드는 스크립트 => 등속도 운동
        // Vector3.MoveTowards(시작 지점, 끝 지점, 속도);
        //Circle.transform.position = Vector3.MoveTowards(Circle.transform.position, pos, 0.002f);

        //Vector3 pos1 = new Vector3(-5, -3, 0);
        //Vector3 pos2 = new Vector3(5, -3, 0);

        //Circle.transform.position = Vector3.Slerp(Circle.transform.position, pos, 0.05f);
        Circle.transform.position = Vector3.Slerp(Circle.transform.position, targetPosition, moveSpeed);

        // 목표 위치에 가까워지면 다른 목표 위치로 변경
        if (Vector3.Distance(Circle.transform.position, targetPosition) < 0.1f)
        {
            // 현재 위치가 pos1에 가까우면 pos2로 목표 변경
            if (targetPosition == pos1)
            {
                targetPosition = pos2;
            }
            // 현재 위치가 pos2에 가까우면 pos1로 목표 변경
            else
            {
                targetPosition = pos1;
            }
        }
    }
}
