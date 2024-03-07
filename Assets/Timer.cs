using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public static float time;

    // Start is called before the first frame update
    void Start()
    {
        time = 0;    
    }

    // 도착하기 전까지 지속적으로 시간 체크
    // UI 텍스트로 실시간 시간 출력
    private void Update()
    {
        if(GoalArea.goal == false)
        {
            time += Time.deltaTime;
        }

        // 타이머 1초, 2초 세고 싶을때
        // int t = (int)time;
        int t = Mathf.FloorToInt(time);

        TextMeshProUGUI tmp = GetComponent<TextMeshProUGUI>();
        tmp.text = "Time : " + t;
    }
}
