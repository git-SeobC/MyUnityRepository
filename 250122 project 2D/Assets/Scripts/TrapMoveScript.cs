using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class Trap : MonoBehaviour
{
    private Transform target; // Circle의 Transform (자동 할당)
    public float speed = 2.0f; // 이동 속도
    private Text message; // 타이핑할 텍스트
    private Image background; // 검정 배경
    private string content; // 출력할 내용
    [SerializeField] private float delay = 0.2f; // 읽는 속도
    public float fadeDuration = 1.5f; // 페이드 인 지속 시간 (초)
    public float textDelay = 0.5f;     // 배경 후 텍스트 등장 딜레이

    void Start()
    {
        GameObject circleObj = GameObject.Find("Circle");
        target = circleObj.transform; // Circle의 Transform 할당
        content = "YOU DIED";

        GameObject canvasObj = GameObject.Find("Canvas");
        // Canvas 내부에서 Text 컴포넌트 찾기
        message = canvasObj.GetComponentInChildren<Text>();
        background = canvasObj.GetComponentInChildren<Image>();
        // 초기 배경 색상 설정 (투명)
        Color bgColor = background.color;
        bgColor.a = 0;
        background.color = bgColor;

        // 초기 텍스트 색상 설정 (투명)
        Color textColor = message.color;
        textColor.a = 0;
        message.color = textColor;
        // 배경 앞으로 설정
        message.transform.SetSiblingIndex(background.transform.GetSiblingIndex() + 1);
    }

    // Update is called once per frame
    void Update()
    {
        if (target == null) return;
        // trap을 target으로 이동
        transform.position = Vector3.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            StartCoroutine("FadeIn");
            StartCoroutine("TypingGameOver");
            Debug.Log("Game Over");
        }
    }

    IEnumerator TypingGameOver()
    {
        message.text = ""; // 현재 화면 메세지 비움

        int typingCount = 0; // 타이핑 카운트 0 초기화
        float elapsedTime = 0f;

        // 텍스트 페이드 인
        elapsedTime = 0f;
        while (elapsedTime < fadeDuration)
        {
            float alpha = elapsedTime / fadeDuration;
            Color textColor = message.color;
            textColor.a = alpha;
            message.color = textColor;

            elapsedTime += Time.deltaTime;
            yield return null;
        }

        // 텍스트를 완전히 불투명하게 설정
        Color finalTextColor = message.color;
        finalTextColor.a = 1;
        message.color = finalTextColor;

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

    IEnumerator FadeIn()
    {
        float elapsedTime = 0f;

        // 배경 페이드 인
        while (elapsedTime < fadeDuration)
        {
            float alpha = elapsedTime / fadeDuration;
            Color bgColor = background.color;
            bgColor.a = alpha;
            background.color = bgColor;

            elapsedTime += Time.deltaTime;
            yield return null;
        }

        // 배경을 완전히 불투명하게 설정
        Color finalBgColor = background.color;
        finalBgColor.a = 1;
        background.color = finalBgColor;
    }
}
