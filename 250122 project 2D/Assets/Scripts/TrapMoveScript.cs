using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class Trap : MonoBehaviour
{
    private Transform target; // Circle�� Transform (�ڵ� �Ҵ�)
    public float speed = 2.0f; // �̵� �ӵ�
    private Text message; // Ÿ������ �ؽ�Ʈ
    private Image background; // ���� ���
    private string content; // ����� ����
    [SerializeField] private float delay = 0.2f; // �д� �ӵ�
    public float fadeDuration = 1.5f; // ���̵� �� ���� �ð� (��)
    public float textDelay = 0.5f;     // ��� �� �ؽ�Ʈ ���� ������

    void Start()
    {
        GameObject circleObj = GameObject.Find("Circle");
        target = circleObj.transform; // Circle�� Transform �Ҵ�
        content = "YOU DIED";

        GameObject canvasObj = GameObject.Find("Canvas");
        // Canvas ���ο��� Text ������Ʈ ã��
        message = canvasObj.GetComponentInChildren<Text>();
        background = canvasObj.GetComponentInChildren<Image>();
        // �ʱ� ��� ���� ���� (����)
        Color bgColor = background.color;
        bgColor.a = 0;
        background.color = bgColor;

        // �ʱ� �ؽ�Ʈ ���� ���� (����)
        Color textColor = message.color;
        textColor.a = 0;
        message.color = textColor;
        // ��� ������ ����
        message.transform.SetSiblingIndex(background.transform.GetSiblingIndex() + 1);
    }

    // Update is called once per frame
    void Update()
    {
        if (target == null) return;
        // trap�� target���� �̵�
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
        message.text = ""; // ���� ȭ�� �޼��� ���

        int typingCount = 0; // Ÿ���� ī��Ʈ 0 �ʱ�ȭ
        float elapsedTime = 0f;

        // �ؽ�Ʈ ���̵� ��
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

        // �ؽ�Ʈ�� ������ �������ϰ� ����
        Color finalTextColor = message.color;
        finalTextColor.a = 1;
        message.color = finalTextColor;

        // ���� ī��Ʈ�� �������� ���̿� �ٸ��ٸ� 
        while (typingCount != content.Length)
        {
            if (typingCount < content.Length)
            {
                message.text += content[typingCount].ToString();
                // ���� ī��Ʈ�� �ش��ϴ� �ܾ� �ϳ��� �޼��� �ؽ�Ʈ UI�� ����
                typingCount++;
                // ī��Ʈ�� 1 ����
            }
            yield return new WaitForSeconds(delay);
            // ������ �����̸�ŭ ���
        }
    }

    IEnumerator FadeIn()
    {
        float elapsedTime = 0f;

        // ��� ���̵� ��
        while (elapsedTime < fadeDuration)
        {
            float alpha = elapsedTime / fadeDuration;
            Color bgColor = background.color;
            bgColor.a = alpha;
            background.color = bgColor;

            elapsedTime += Time.deltaTime;
            yield return null;
        }

        // ����� ������ �������ϰ� ����
        Color finalBgColor = background.color;
        finalBgColor.a = 1;
        background.color = finalBgColor;
    }
}
