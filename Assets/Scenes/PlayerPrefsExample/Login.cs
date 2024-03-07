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
            // ����� ������ ��ġ�ϴ��� ��
            string savedID = PlayerPrefs.GetString("ID");
            string savedPW = PlayerPrefs.GetString("PW");

            // ȸ�������� �Ǿ����� ���
            if (ID_Field.text == savedID && PW_Field.text == savedPW)
            {
                OnButtonExit("�α��� ��");
                Logout.SetActive(true);
            }

            // �ƴҰ��
            else
            {
                OnButtonExit("ȸ������ ����");
            }
        }

        else 
        {
            OnButtonExit("���� �Է� ���");
        }
    }

    public void SignInField()
    {
        if (ID_Field.text != "" && PW_Field.text != "")
        {
            PlayerPrefs.SetString("ID", ID_Field.text);
            PlayerPrefs.SetString("PW", PW_Field.text);
            OnButtonExit("ȸ������ �Ϸ�");
            Logout.SetActive(true);
        }
        else
        {
            OnButtonExit("���� �Է� ���");
        }
    }

    public void LogoutField()
    {
        ID_Field.text = "";
        PW_Field.text = "";
        Logout.SetActive(false );
        OnButtonExit("�α׾ƿ� ��");
    }

    public void OnButtonExit(string message)
    {
        Message.SetActive(true);
        Message.GetComponent<Text>().text = message;
        Invoke("SetMessage", 1.0f);
    }
}
