using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemManager_heal : MonoBehaviour {

    public PlayerHealth playerHealth;
    public GameObject Item;
    public float spawnTime = 0.1f;
    public Transform[] spawnPoints;
    GameObject act;

    void Start()
    {
        InvokeRepeating("Spawn", 1, 5);
      
    }


    void Spawn()
    {

        if (playerHealth.currentHealth <= 0f)
        {
            return;
        }

        int spawnPointIndex = Random.Range(0, spawnPoints.Length);

        if (GameObject.FindWithTag("Heal") == null)
        {
            Instantiate(Item, spawnPoints[spawnPointIndex].position, spawnPoints[spawnPointIndex].rotation);
        }
    }
}
