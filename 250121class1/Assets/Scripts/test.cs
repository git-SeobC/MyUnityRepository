using Unity.VisualScripting;
using UnityEngine;
// using�� ������ ���� ���� �ڵ忡�� ����ϴ� ���̶�� ǥ��
// ����Ƽ���� ����Ƽ�� Ȱ���� �۾��ϴ� ��ũ��Ʈ���
// ���� �ڵ带 �ݵ�� �߰����־�� ��(�ڵ����� �߰��Ǿ������� ����� ��찡 ����)

// ���ӽ����̽��� Ư�� ����� �ϴ� Ŭ������ ��ǥ���� �̸����ν� ���
namespace UnityTutorial
{
    // UnityTutorial �������� ������� SampleA Ŭ����
    // namespace�� ������ �������ִ� �����̶�� ���� ��
    public class SampleA
    {

    }
}

public class SampleA
{

}

/// <summary>
/// ó������ ���� ����Ƽ�� ��ũ��Ʈ
/// </summary>
public class test : MonoBehaviour
    // MonoBehaviour�� Ŭ������ �������� ���
    // ����Ƽ Scene�� �����ϴ� ������Ʈ�� ��ũ��Ʈ�� ������ �� �ְ� ����.
    // �߰������� ����Ƽ���� �������ִ� ����� ����Ҷ� ���.
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
        Debug.Log($"{count} �¿� �ݺ� �ٱ�");
        count++; // count�� 1����
    }
}
