using UnityEngine;

public class DataSample : MonoBehaviour
{

    // 1. ����Ƽ �������� ����
    // ������ ���� �������� ���� �ٽ��� �Ǵ� �κ�(������)

    // �Ϲ����� �۾� �� , �÷����ϴ� ��쿡�� ���� ���� �����ǰ�, �ٽ� �÷����ϸ� ������ ��ϵ��� ���ŵ�

    // ���� ���ο� ���� �÷����� �� ������ ������ ������ �����ϴ� ���ӵ� ����
    // PlayerPrefs�� �ַ� �÷��̾ ���� ȯ�� ������ ������ �� ���Ǵ� Ŭ����
    // �ش� Ŭ������, ���ڿ�, �Ǽ�, ������ ������� �÷��� ������Ʈ���� ������ �� ����

    // PlayerPrefs�� Key�� Value�� �����Ǿ� �ִ� ������ -> C#�� Dictionary�� ������ ����

    // Key�� Value�� �����ϱ� ���� ������(���� �������� ��ġ)
    // Value�� Key�� ���� ������ �� �ִ� �������� ��
    // ex) userID : current147�� ����Ǿ��ֵ���, userID�� key, current147�� value

    public UserData userData;
    // 1. ����Ƽ �����Ϳ��� ���� userData�� ���� ������ �� �ۼ�
    // 2. ������Ʈ���� �ִ� Ű ���� �˻��غ���
    // 3. Ű ��ü ����

    private void Start()
    {
        // 1.
        //PlayerPrefs.SetString("ID", userData.UserID);
        //PlayerPrefs.SetString("UserName", userData.UserID);
        //PlayerPrefs.SetString("Password", userData.UserPassword);
        //PlayerPrefs.SetString("e-Mail", userData.UserEmail);

        //Debug.Log("Data Save complete");

        // 2.
        //Debug.Log(PlayerPrefs.GetString("ID"));

        //PlayerPrefs.DeleteAll(); // ��ü ����
        //Debug.Log("Data's Deleted");
    }

}
