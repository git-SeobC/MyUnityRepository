using UnityEngine;

public class UserDataSystem : MonoBehaviour
{
    public UserData data;

    public UserData data1;
    public UserData data2;



    // PlayerPrefs 기능
    // 1. DeleteAll() : 삭제 기능
    // 2. DeleteKey(키 이름) : 해당 키와 해당하는 값 삭제
    // 3. GetFloat/Int/String(키 이름) : 키에 해당하는 값을 return
    //                                  데이터 타입에 맞춰 사용 해야 함.
    // 4. SetFloat/Int/String(키 이름, 값) : 해당 키 - 값을 생성
    //                                      기존에 같은 키가 있다면,
    //                                      값만 변경됨.
    // 5. HasKey(키 이름) : 해당 키가 존재하는지를 확인


    private void Start()
    {
        data1 = new UserData();
        // 클래스 생성 방법
        // 클래스변수(레퍼런스)명 = new 생성자();

        data2 = new UserData("skhynix", "sk", "hynix", "gagopadonmanijooneungote");

        // data2의 데이터를 아이디, 이름, 비빌번호, 이메일 순으로 빼옴.
        string data_value = data2.GetData();
        Debug.Log(data_value);

        PlayerPrefs.SetString("data1", data_value); // 그 데이터로 data1로 저장
        //PlayerPrefs.Save(); // 변경된 값 전부 저장

        data1 = UserData.SetData(data_value); // data1을 전달받은 데이터로 설정

        Debug.Log(data1.GetData()); // data1에 제대로 전달되었는지 확인

    }

}
