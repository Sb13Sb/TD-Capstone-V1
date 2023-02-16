using UnityEngine;
using UnityEngine.UI;

public class RoundsUI : MonoBehaviour
{

	public Text roundText;

	// Update is called once per frame
	void Update()
	{
		roundText.text = "Round " + PlayerStats.Rounds.ToString();
	}
}