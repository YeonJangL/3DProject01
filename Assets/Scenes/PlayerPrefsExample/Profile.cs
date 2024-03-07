using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class Profile : MonoBehaviour
{
    public Text Name_field;
    public Text Age_field;
    public Text Job_field;

    public GameObject Message; // UI Text ����

    private void Start()
    {
        SetMessage();
    }

    public void SetMessage()
    {
        Message.SetActive(false);
    }

    public void SaveInputField()
    {
      if(Name_field.text != "" && Age_field.text != "" && Job_field.text != "")
        {
            PlayerPrefs.SetString("Name", Name_field.text);
            PlayerPrefs.SetInt("Age", int.Parse(Age_field.text));
            PlayerPrefs.SetString("Job", Job_field.text);

            OnButtonExit("���� �Ϸ�");
        }
      else
        {
            OnButtonExit("�ڷ� ����");
        }
    }

    public void LoadInputField()
    {
        // �ش� ������ ����ǰ� �ִ� ��Ȳ�� ��� ���� ����
        if (PlayerPrefs.HasKey("Name") && PlayerPrefs.HasKey("Age") && PlayerPrefs.HasKey("Job"))
        {
            Name_field.text = PlayerPrefs.GetString("Name");
            Age_field.text = PlayerPrefs.GetInt("Age").ToString();
            Job_field.text = PlayerPrefs.GetString("Job") ;
        }
        else
        {
            OnButtonExit("�������");
        }
    }

    public void OnButtonExit(string message)
    {
        Message.SetActive(true);
        Message.GetComponent<Text>().text = message;
        Invoke("SetMessage", 1.0f);
    }
}
