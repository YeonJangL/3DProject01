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
        resultUI.SetActive(false); // ��� UI ��Ȱ��ȭ
        // �÷��̾� ������ : ����Ƽ���� �����͸� ������ �� ����ϴ� Ŭ����

        if(PlayerPrefs.HasKey("HighScore")) // �ش� Ű�� �����ϸ�
        {
            highScore = PlayerPrefs.GetInt("HighScore"); // �� ������ ����
        }
        else
        {
            highScore = 999; // �����س��� �⺻ ������ ó��
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (GoalArea.goal) // ��ǥ������ ����
        {
            resultUI.SetActive(true); // ��� UI â Ȱ��ȭ
            int result = Mathf.FloorToInt(Timer.time);
            // Ÿ�̸ӿ��� ������ �ð��� �Ҽ����� ���� ������ ǥ��
            resultTime.text = "ResultTime : " + result;
            bestTime.text = "BestTime : " + highScore;
            // �ؽ�Ʈ�� �� ����

            if (highScore > result)
            {
                PlayerPrefs.SetInt("HighScore", result);
                // HighScore Ű�� ���� result�� ������ ����
                // ������ Ű�� �����ϴ� ��� ���� ���������, ���� ��� ������ (Dictionary ����)
            }
        }
    }

    public void OnRetry()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
