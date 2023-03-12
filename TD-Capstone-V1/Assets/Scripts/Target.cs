using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    private void Start()
    {
        StartCoroutine(DestroyTarget());
    }

    IEnumerator DestroyTarget()
    {
        yield return new WaitForSeconds(2);
        Trainer.targetsMissed++;
        if (Trainer.gameOver == false)
        {
            Trainer.instance.Spawntargets();
        }
        Destroy(gameObject);
    }

    private void OnMouseDown()
    {
        Trainer.targetsHit++;
        Destroy(gameObject);
        if (Trainer.gameOver == false)
        {
            Trainer.instance.Spawntargets();
        }
    }
}