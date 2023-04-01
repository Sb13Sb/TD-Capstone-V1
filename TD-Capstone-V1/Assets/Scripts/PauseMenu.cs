using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{

	public GameObject ui;

	public SceneFader sceneFader;

	void Update()
	{
		if (Input.GetKeyDown(KeyCode.Escape) || Input.GetKeyDown(KeyCode.P))
		{
			Toggle();
		}
	}

	public void Toggle()
	{
		ui.SetActive(!ui.activeSelf);

		if (ui.activeSelf)
		{
			Time.timeScale = 0f;
		}
		else
		{
			Time.timeScale = 1f;
		}
	}

	public void Retry()
	{
		Toggle();
        sceneFader.FadeTo(SceneManager.GetActiveScene().name);
		PlayerStats.Rounds = 0;
	}

    public void Menu()
	{
		Toggle();
		sceneFader.FadeTo("MainMenu");
		PlayerStats.Rounds = 0;
	}

    public void Settings()
	{
		Toggle();
		sceneFader.FadeTo("Settings");
	}

}