using Unity.VisualScripting;
using UnityEngine;
// using은 다음에 적힌 것을 코드에서 사용하는 중이라는 표시
// 유니티에서 유니티를 활용해 작업하는 스크립트라면
// 위의 코드를 반드시 추가해주어야 함(자동으로 추가되어있지만 지우는 경우가 있음)

// 네임스페이스는 특정 기능을 하는 클래스의 대표적인 이름으로써 사용
namespace UnityTutorial
{
    // UnityTutorial 영역에서 만들어진 SampleA 클래스
    // namespace는 영역을 구분해주는 역할이라고 보면 됨
    public class SampleA
    {

    }
}

public class SampleA
{

}

/// <summary>
/// 처음으로 만들어본 유니티의 스크립트
/// </summary>
public class test : MonoBehaviour
    // MonoBehaviour는 클래스에 연결했을 경우
    // 유니티 Scene에 존재하는 오브젝트에 스크립트를 연결할 수 있게 해줌.
    // 추가적으로 유니티에서 제공해주는 기능을 사용할때 사용.
{

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("Do something message.");
    }

    int count = 0;

    // Update is called once per frame
    void Update()
    {
        Debug.Log($"{count} 좌우 반복 뛰기");
        count++; // count가 1증가
    }
}
