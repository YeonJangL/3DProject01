using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPrefsExample2 : MonoBehaviour
{
    public PlayerData playerData;

    public void SaveData()
    {
        PlayerPrefs.SetInt("Player_HP", playerData.HP);
        PlayerPrefs.SetInt("Player_MaxHP", playerData.MaxHP);
        PlayerPrefs.SetInt("Player_Attack", playerData.attack);
    }

    public void LoadData()
    {
        playerData.HP = PlayerPrefs.GetInt("Player_HP");
        playerData.HP = PlayerPrefs.GetInt("Player_MaxHP");
        playerData.HP = PlayerPrefs.GetInt("Player_Attack");
    }
}
