
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_hell : MonoBehaviour
{
    public PlayerHealth playerHealth;
    public GameObject enemy;
    public GameObject enemy_B;
    // public float spawnTime = 1f;
    public Transform[] spawnPoints;
    int count = 0;
    int invoke = 0;

    void Update()
    {
        
        if (ScoreManager.score >= 550 && count == 0)
        {
            InvokeRepeating("Spawn", 1, 20);
            count++;

        }


        else if (ScoreManager.score >= 1000 && count == 1)
        {
            if (ScoreManager.score >= 1000 && invoke == 0)
            {
                CancelInvoke();
                invoke++;

            }
            InvokeRepeating("Spawn", 1, 15);
            count++;
        }
        else if (ScoreManager.score >= 2000 && count == 2)
        {
            if (ScoreManager.score >= 2000 && invoke == 1)
            {
                CancelInvoke();
                invoke++;
                Instantiate(enemy_B, spawnPoints[0].position, spawnPoints[0].rotation);
            }
            InvokeRepeating("Spawn", 1, 10);
            count++;
        }

        else if (ScoreManager.score >= 4000 && count == 3)
        {
            if (ScoreManager.score >= 4000 && invoke == 2)
            {
                CancelInvoke();
                invoke++;
                Instantiate(enemy_B, spawnPoints[0].position, spawnPoints[0].rotation);
            }
            InvokeRepeating("Spawn", 1, 10);
            count++;
        }


    }

    void Spawn()
    {
        if (playerHealth.currentHealth <= 0f)
        {
            return;
        }

        int spawnPointIndex = Random.Range(0, spawnPoints.Length);




        Instantiate(enemy, spawnPoints[spawnPointIndex].position, spawnPoints[spawnPointIndex].rotation);

    }

    void Spawn_B()
    {
        if (playerHealth.currentHealth <= 0f)
        {
            return;
        }

        int spawnPointIndex = Random.Range(0, spawnPoints.Length);




        Instantiate(enemy_B, spawnPoints[spawnPointIndex].position, spawnPoints[spawnPointIndex].rotation);

    }
}