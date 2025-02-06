using UnityEngine;

public class UserDataSystem : MonoBehaviour
{
    public UserData data;

    public UserData data1;
    public UserData data2;



    // PlayerPrefs ���
    // 1. DeleteAll() : ���� ���
    // 2. DeleteKey(Ű �̸�) : �ش� Ű�� �ش��ϴ� �� ����
    // 3. GetFloat/Int/String(Ű �̸�) : Ű�� �ش��ϴ� ���� return
    //                                  ������ Ÿ�Կ� ���� ��� �ؾ� ��.
    // 4. SetFloat/Int/String(Ű �̸�, ��) : �ش� Ű - ���� ����
    //                                      ������ ���� Ű�� �ִٸ�,
    //                                      ���� �����.
    // 5. HasKey(Ű �̸�) : �ش� Ű�� �����ϴ����� Ȯ��


    private void Start()
    {
        data1 = new UserData();
        // Ŭ���� ���� ���
        // Ŭ��������(���۷���)�� = new ������();

        data2 = new UserData("skhynix", "sk", "hynix", "gagopadonmanijooneungote");

        // data2�� �����͸� ���̵�, �̸�, �����ȣ, �̸��� ������ ����.
        string data_value = data2.GetData();
        Debug.Log(data_value);

        PlayerPrefs.SetString("data1", data_value); // �� �����ͷ� data1�� ����
        //PlayerPrefs.Save(); // ����� �� ���� ����

        data1 = UserData.SetData(data_value); // data1�� ���޹��� �����ͷ� ����

        Debug.Log(data1.GetData()); // data1�� ����� ���޵Ǿ����� Ȯ��

    }

}
