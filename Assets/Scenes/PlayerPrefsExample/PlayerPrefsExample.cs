using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPrefsExample : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
       /* PlayerPrefs.SetInt("Red Apple", 5);
        PlayerPrefs.SetString("Way", "Lake como");
        Debug.Log("Red Apple 5개를 획득했나보다");
        Debug.Log("현재 위치는 " + PlayerPrefs.GetString("Way"));*/

        // 1회 실행 이후 위의 코드는 주석으로 막아줌

        if (PlayerPrefs.HasKey("Red Apple"))
        {
            Debug.Log("현재 Red Apple 개수는 " + PlayerPrefs.GetInt("Red Apple") + "개 인듯");
        }
    }

    public void UseApple()
    {
        if (PlayerPrefs.HasKey("Red Apple"))
        {
            int count = PlayerPrefs.GetInt("Red Apple");
            count--;
            Debug.Log("현재 Red Apple 개수는 " + PlayerPrefs.GetInt("Red Apple") + "개 인듯");
            PlayerPrefs.SetInt("Red Apple", count);

            if (PlayerPrefs.GetInt("Red Apple") <= 0 )
            {
                PlayerPrefs.DeleteKey("Red Apple");
            }
        }
        else
        {
            Debug.Log("사과 없음");
            return;
        }
    }
}
