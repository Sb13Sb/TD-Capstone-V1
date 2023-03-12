using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Trainer : MonoBehaviour
{
    public GameObject targetPrefab;
    public static Trainer instance;
    public static bool gameOver;
    public static int targetsHit = 0, targetsMissed = 0, accuracy;

    public TextMeshProUGUI targetsHitLbl, targetsMissedLbl, accuracyLbl;

    private void Start()
    {
        Spawntargets();
        gameOver = false;
        instance = this;
    }

    private void Update()
    {
        int sum = targetsHit + targetsMissed;
        if (sum > 0)
        {
            accuracy = (int)(((float)targetsHit / sum) * 100);
        }
        else
        {
            accuracy = 0;
        }

        targetsHitLbl.text = "Hit: " + targetsHit;
        targetsMissedLbl.text = "Missed: " + targetsMissed;
        accuracyLbl.text = "Accuracy: " + accuracy.ToString() + "%";
    }

    public void Spawntargets()
    {
        Vector3 randomSpawn = new Vector3(Random.Range(-3, 3), 3, Random.Range(-3, 3));
        Instantiate(targetPrefab, randomSpawn, Quaternion.identity);
    }
}