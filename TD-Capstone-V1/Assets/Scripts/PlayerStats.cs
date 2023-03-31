using UnityEngine;
using System.Collections;

public class PlayerStats : MonoBehaviour
{

    public static int Money;
    public int startMoney = 300;

    public static int Lives;
    public int startLives = 20;

    public static int Rounds;
    public int startRounds = 0;

    void Start()
    {
        if (Rounds == 0)
        {
            Money = startMoney;
            Lives = startLives;
            Rounds = startRounds;
        }
        else
        {
            UpdatedStats();
        }

    }
    void UpdatedStats()
    {
        int currentMoney = PlayerPrefs.GetInt("Money");

        int Money = currentMoney;
        PlayerPrefs.SetInt("Money", Money);
        PlayerPrefs.Save();

        int currentLives = PlayerPrefs.GetInt("Lives");

        int Lives = currentLives;
        PlayerPrefs.SetInt("Lives", Lives);
        PlayerPrefs.Save();

        int currentRounds = PlayerPrefs.GetInt("Rounds");

        int Rounds = currentRounds;
        PlayerPrefs.SetInt("Rounds", Rounds);
        PlayerPrefs.Save();
    }
}