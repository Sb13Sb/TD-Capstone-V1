using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    public TextMeshProUGUI timerLbl;
    public float timer = 60f;


    private void Update()
    {
       if(timer > 0)
        {
            timer -= Time.deltaTime;
            DisplayTime(timer);
        }
        else
        {
            Trainer.gameOver = true;
            Trainer.IfTrainer = true;
            Debug.Log("Trainer = true");
            timerLbl.text = "Game Over!";
            PlayerStats.Rounds++;
            SceneManager.LoadScene(2);
        }
    }

    private void DisplayTime(float displayTime)
    {
        float minutes = Mathf.FloorToInt(displayTime / 60);
        float seconds = Mathf.FloorToInt(displayTime % 60);
        timerLbl.text = $"{seconds}";
    }

}
