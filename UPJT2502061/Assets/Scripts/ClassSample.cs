using UnityEngine;


class Unit
{
    // Ŭ�������� �ش� Ŭ������ ���� ��ü�� ������ �ۼ�
    public string unit_name;

    // Ŭ������ �ش� Ŭ������ ���� ��ü�� ����, ����� �ۼ��� �� ����(�޼ҵ�)
    public static void UnitAction()
    {
        Debug.Log("������ �����մϴ�.");
    }

    public void Cry()
    {
        Debug.Log("������ ���¢�����ϴ�.");
    }
}



public class ClassSample : MonoBehaviour
{
    Unit unit; //Unit Ŭ���� �������� ���� unit ��ü(object)

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        unit.unit_name = "minigun";
        // Ŭ����������.�ʵ� �� ���� Ŭ������ ������ �ִ� �ʵ�(����)�� ����� �� ����

        unit.Cry();
        // �ν��Ͻ���.�޼ҵ�()�� ���� Ŭ������ ������ �ִ� �޼ҵ带 ����� �� ����

        // Ŭ���� ������� ���� ��Ī
        // ��ü : ���� ������, Ŭ������ �� ��ü�� ����� ���� ���ø� ����

        // ���۷��� : ��ü�� �޸� �󿡼��� ��ġ�� ����Ű�� ��
        // Ŭ������ �迭, �������̽� ���� �ش�

        // �ν��Ͻ� : ��ü�� ����Ʈ����� ��üȭ�� �� (new�� ���ؼ� ����������� �ν��Ͻ�)
        // ex) Animal cat = new Animal();


        Unit.UnitAction();
        //static�� ���� ������ �Լ��� ��ü�� �������� �ʰ� Ŭ�������� �ٷ� �� ����� ������ ���
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
