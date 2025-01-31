using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class TypingText : MonoBehaviour
{
    public Text message; // 타이핑할 텍스트
    [SerializeField][TextArea] private string content; // 출력할 내용
    [SerializeField] private float delay = 0.2f; // 읽는 속도

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    public void OnMessageButtonClick()
    {
        StartCoroutine("Typing");
    }

    /// <summary>
    /// 2배속 기능
    /// </summary>
    public void ByTwo()
    {
        if (delay == 0.2f)
        {
            delay = 0.1f;
        }
        else
        {
            delay = 0.2f;
        }
    }

    IEnumerator Typing()
    {
        message.text = ""; // 현재 화면 메세지 비움

        int typingCount = 0; // 타이핑 카운트 0 초기화

        // 현재 카운트가 컨텐츠의 길이와 다르다면 
        while (typingCount != content.Length)
        {
            if (typingCount < content.Length)
            {
                message.text += content[typingCount].ToString();
                // 현재 카운트에 해당하는 단어 하나를 메세지 텍스트 UI에 전달
                typingCount++;
                // 카운트를 1 증가
            }
            yield return new WaitForSeconds(delay);
            // 현재의 딜레이만큼 대기
        }
    }
}
