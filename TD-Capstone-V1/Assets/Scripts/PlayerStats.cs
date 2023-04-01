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

    void Update()
    {
        if (Rounds == 0)
        {
            Money = startMoney;
            Lives = startLives;
            Rounds = startRounds;
        }
        /*else
        {
            int currentMoney = 0;
            currentMoney = PlayerPrefs.GetInt("Money");
            PlayerPrefs.SetInt("Money", Money);
            Money = currentMoney;
                int bonusPoints = 0;

                if (Trainer.accuracy >= 80)
                {
                    bonusPoints = 200;
                }
                else if (Trainer.accuracy < 60 || Trainer.accuracy > 80)
                {
                    bonusPoints = 100;
                }
                else
                {
                    bonusPoints = 100;
                }
                int newMoney = currentMoney + bonusPoints;
                PlayerPrefs.SetInt("Money", newMoney);
                newMoney = Money; 
                PlayerPrefs.Save();

        }*/

    }
    
}