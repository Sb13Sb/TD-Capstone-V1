using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour
{

	public static bool GameIsOver;

	public GameObject gameOverUI;

	void Start()
	{
		GameIsOver = false;
	}

	void Update()
	{
		if (GameIsOver)
			return;

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