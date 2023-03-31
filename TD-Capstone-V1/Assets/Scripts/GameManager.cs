using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

	public static bool GameIsOver;

    public GameObject gameOverUI;

	public bool IfTrainer;

	void Start()
	{
		GameIsOver = false;
	}

	void Update()
	{
		if (GameIsOver)
        {
		return;
        }

		if (IfTrainer == false)
		{
			Debug.Log("IfTrainer is false");
			if (PlayerStats.Rounds > 0 && PlayerStats.Rounds % 6 == 0)
            {
                Debug.Log("Loading scene 3");
				SceneManager.LoadScene(3);
			}
			
		}


        if (PlayerStats.Lives <= 0)
		{
		EndGame();
		}
	}

	void EndGame()
	{
		GameIsOver = true;
		gameOverUI.SetActive(true);
	}

}