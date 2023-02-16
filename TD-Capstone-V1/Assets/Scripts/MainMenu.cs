using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

	public string levelToLoad = "MainLevel";

	public SceneFader sceneFader;

	public void Play ()
	{
		sceneFader.FadeTo(levelToLoad); //Fades scene to next scene
	}

	 public void Quit ()
    {
        Debug.Log("Exciting...");
		UnityEditor.EditorApplication.isPlaying = false; //this quits the editor so i dont quit unity (testing purposes)

		Application.Quit(); //this is for final game but would quit unity in editor
    
	}

}
