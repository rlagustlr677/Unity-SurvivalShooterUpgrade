using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemManager_power : MonoBehaviour {

    public PlayerHealth playerHealth;
    public GameObject Item;
    public float spawnTime = 0.1f;
    public Transform[] spawnPoints;
    GameObject act;

    void Start()
    {
        InvokeRepeating("Spawn", spawnTime, spawnTime);
       
    }


    void Spawn()
    {

        if (playerHealth.currentHealth <= 0f)
        {
            return;
        }

        int spawnPointIndex = Random.Range(0, spawnPoints.Length);

        if (GameObject.FindWithTag("PowerUp") == null)
        {
            Instantiate(Item, spawnPoints[spawnPointIndex].position, spawnPoints[spawnPointIndex].rotation);
        }
    }
}
