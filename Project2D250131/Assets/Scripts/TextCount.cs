using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class TextCount : MonoBehaviour
{
    // 텍스트에 카운트를 출력하는 기능을 구현.
    // 카운트는 계속 1씩 증가하는 형태로 처리.
    public Text countText;
    private int count;

    void Start()
    {
        // Coroutine 사용 방법
        // StartCoroutine("함수의 이름(IEnumerator 형태의 함수)");
        // 1. 문자열(함수 이름)을 통해 함수를 찾아서 실행하는 방식
        // >> 오타가 발생해도 오류가 발생하진 않음. 그러나 제대로 실행 X
        // StopCoroutine()을 통해 외부에서 중지하는 것이 가능.

        // StartCoroutine(함수의 이름());
        // 2. 해당 함수를 호출해서 실행 결과를 반환받는 형태
        // >> 오타 발생 시 오류 체크 가능

        // 이 방식으로는 StopCoroutine()을 통한 외부에서의 중지 기능을 사용할 수 없음.

        StartCoroutine("CountPlus");
        // 해당 코루틴 중지 제어 가능
        //StopCoroutine("CountPlus");

        //StartCoroutine(CountPlus());
        // 함수 형태의 실행 방식 -> 함수가 끝까지 마무리 될때까지 중간에서 변경 불가능
    }

    IEnumerator CountPlus()
    {
        while (true)
        {
            count++;
            countText.text = count.ToString("N0");
            // C# ToString() 을 통해 문자 형태로 변환 가능
            // N0는 숫자 3자리 간격으로 ',' 를 표시하는 format -> 1000 => 1,000
            yield return new WaitForSeconds(1);
            // 다음 동작으로 넘어갑니다.
        }

        //Debug.Log("아이스 아메리카노 마이크 테스트");
        //yield return new WaitForSeconds(1);
        //// yield는 일시적으로 CPU의 권한을 다른 함수에 위임하는 키워드
        //Debug.Log("아삼스 아메리카노 마삼크 테스트");
        //yield return new WaitForSeconds(5);
        //Debug.Log("아사스 아메리카노 마사크 테스트");
    }
}
