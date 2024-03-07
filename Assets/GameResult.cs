using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class GameResult : MonoBehaviour
{
    private int highScore;
    public TextMeshProUGUI resultTime;
    public TextMeshProUGUI bestTime;
    public GameObject resultUI;

    // Start is called before the first frame update
    void Start()
    {
        resultUI.SetActive(false); // 결과 UI 비활성화
        // 플레이어 프립스 : 유니티에서 데이터를 저장할 때 사용하는 클래스

        if(PlayerPrefs.HasKey("HighScore")) // 해당 키가 존재하면
        {
            highScore = PlayerPrefs.GetInt("HighScore"); // 그 값으로 설정
        }
        else
        {
            highScore = 999; // 설정해놓은 기본 값으로 처리
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (GoalArea.goal) // 목표지점에 도달
        {
            resultUI.SetActive(true); // 결과 UI 창 활성화
            int result = Mathf.FloorToInt(Timer.time);
            // 타이머에서 측정한 시간의 소수점을 버려 정수로 표시
            resultTime.text = "ResultTime : " + result;
            bestTime.text = "BestTime : " + highScore;
            // 텍스트에 값 전달

            if (highScore > result)
            {
                PlayerPrefs.SetInt("HighScore", result);
                // HighScore 키를 만들어서 result를 값으로 설정
                // 기존에 키가 존재하는 경우 값이 덮어써지고, 없는 경우 생성됨 (Dictionary 구조)
            }
        }
    }

    public void OnRetry()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
