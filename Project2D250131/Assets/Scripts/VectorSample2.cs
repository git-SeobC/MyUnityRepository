using UnityEngine;

public class VectorSample2 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // 1. Normalization(정규화)
        // 백터의 크기를 1로 설정, 같은 방향을 가지되 크기만 1로
        // 크기를 1로 고정하게 되면, 벡터의 방향만 고려하면 다음 연산을 처리하기 쉽기 때문
        // ex) 입력으로 캐릭터의 3D 이동 진행시 이동이 대각일 경우 일반적인 단일 방향보다 이동속도가 더 빠른 상황이 발생할 수 있음.
        Vector3 a = new Vector3(1, 2, 0);
        Vector3 normalA = a.normalized;

        // 2. 두 지점 사이의 거리 계산
        Vector3 positionA = new Vector3(1, 2, 3);
        Vector3 positionB = new Vector3(4, 5, 6);

        float distance = Vector3.Distance(positionA, positionB);
        // 두 벡터의 차이 크기 계산
        // 사거리 계산에 사용될 수 있음

        // 3. 선형 보간(Linear Interpolation) -> Lerp
        // 끝 점의 값이 제공되었을 때 그 사이에 위치한 값을 추정하기 위해 직선거리에 따라 선형적으로 계산하는 방식, 보통 부드러운 움직임을 구현할 때 사용
        Vector3 result = Vector3.Lerp(positionA, positionB, 0.5f);
        // ex) A지점이 (2,1)이고 B지점이 (6,4)일 때 그 사이의 지점 C의 X 좌표가 주어진다면, Y 좌표까지 얻어낼 수 있음

    }

    // Update is called once per frame
    void Update()
    {

    }
}
