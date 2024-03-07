using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Login : MonoBehaviour
{
    public InputField ID_Field;
    public InputField PW_Field;

    public GameObject Message;
    public GameObject Logout;

    public void Start()
    {
        SetMessage();
        Logout.SetActive(false);
    }

    public void SetMessage()
    {
        Message.SetActive(false);
    }

    public void LoginField()
    {
        if (ID_Field.text != "" && PW_Field.text != "")
        {
            // 저장된 정보와 일치하는지 비교
            string savedID = PlayerPrefs.GetString("ID");
            string savedPW = PlayerPrefs.GetString("PW");

            // 회원가입이 되어있을 경우
            if (ID_Field.text == savedID && PW_Field.text == savedPW)
            {
                OnButtonExit("로그인 됨");
                Logout.SetActive(true);
            }

            // 아닐경우
            else
            {
                OnButtonExit("회원정보 없음");
            }
        }

        else 
        {
            OnButtonExit("정보 입력 요망");
        }
    }

    public void SignInField()
    {
        if (ID_Field.text != "" && PW_Field.text != "")
        {
            PlayerPrefs.SetString("ID", ID_Field.text);
            PlayerPrefs.SetString("PW", PW_Field.text);
            OnButtonExit("회원가입 완료");
            Logout.SetActive(true);
        }
        else
        {
            OnButtonExit("정보 입력 요망");
        }
    }

    public void LogoutField()
    {
        ID_Field.text = "";
        PW_Field.text = "";
        Logout.SetActive(false );
        OnButtonExit("로그아웃 됨");
    }

    public void OnButtonExit(string message)
    {
        Message.SetActive(true);
        Message.GetComponent<Text>().text = message;
        Invoke("SetMessage", 1.0f);
    }
}
