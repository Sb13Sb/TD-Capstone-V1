using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class WaveSpawner : MonoBehaviour
{
	public SceneFader sceneFader;

	public Transform enemyPrefab;

	public Transform spawnPoint;

	public float timeBetweenWaves = 5f;
	private float countdown = 2f;

	public Text waveCountdownText;

	private int waveIndex = 0;

	void Update()
	{
		if (countdown <= 0f)
		{
			StartCoroutine(SpawnWave());
			countdown = timeBetweenWaves;
		}

		countdown -= Time.deltaTime;

		countdown = Mathf.Clamp(countdown, 0f, Mathf.Infinity);
	}

	IEnumerator SpawnWave()
	{
		if (SceneManager.GetActiveScene().name == "SpecialRound")
		{
			yield return new WaitForSeconds(60f);
		}
		else
		{
			waveIndex++;
			PlayerStats.Rounds++;

			for (int i = 0; i < waveIndex; i++)
			{

				SpawnEnemy();
				yield return new WaitForSeconds(0.5f);

			}
		}
	}

	void SpawnEnemy()
	{
		Instantiate(enemyPrefab, spawnPoint.position, spawnPoint.rotation);
	}

}