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

    // �����ϱ� ������ ���������� �ð� üũ
    // UI �ؽ�Ʈ�� �ǽð� �ð� ���
    private void Update()
    {
        if(GoalArea.goal == false)
        {
            time += Time.deltaTime;
        }

        // Ÿ�̸� 1��, 2�� ���� ������
        // int t = (int)time;
        int t = Mathf.FloorToInt(time);

        TextMeshProUGUI tmp = GetComponent<TextMeshProUGUI>();
        tmp.text = "Time : " + t;
    }
}
