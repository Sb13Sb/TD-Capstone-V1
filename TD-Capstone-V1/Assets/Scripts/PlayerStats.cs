using UnityEngine;
using System.Collections;

public class PlayerStats : MonoBehaviour {

	public static int Money;

	public static int Lives;

	public static int Rounds;

	void Awake ()
	{
		Money = 350;

		Lives = 3;

		Rounds = 0;
	}

}
