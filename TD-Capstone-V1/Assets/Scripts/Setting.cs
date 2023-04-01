using UnityEngine;
using UnityEngine.SceneManagement;


public class Setting : MonoBehaviour
{

    void Update()
	{
		if (Input.GetKeyDown(KeyCode.Escape))
		{
            SceneManager.LoadScene(2);
            Debug.Log("escape key pressed");
        }
    }
}

