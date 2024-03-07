using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Login : MonoBehaviour
{
    public TextMeshProUGUI inputField_ID;
    public TextMeshProUGUI inputField_PW;
    public Button Button_Save;
    public Button Button_Load;

    private string user = null;
    private string password = null;

    public void SaveButtonClick()
    {
        if(inputField_ID.text.Length > 0 && inputField_PW.text.Length > 0)
        {
            Debug.Log("ÀúÀå");
        }
    }
}
