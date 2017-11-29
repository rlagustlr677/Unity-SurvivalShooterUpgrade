using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Healing : MonoBehaviour {

    GameObject player;
    PlayerHealth playerhp;
    AudioSource heal_audio;
    Renderer rend;
    public bool active = true;
	// Use this for initialization
	void Start () {

        player = GameObject.FindGameObjectWithTag("Player");

        playerhp = player.GetComponent<PlayerHealth>();

        rend = GetComponent<Renderer>();

        heal_audio = GetComponent<AudioSource>();

        
	}
	
	// Update is called once per frame
	void Update () {
        transform.Rotate(0,5,0,0);
    }

    IEnumerator OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player") && active)
        {

            heal_audio.Play();

            playerhp.Heal(70);           

            active = false;

            rend.enabled = false;

            yield return new WaitForSeconds(5.0f);

            Object.Destroy(gameObject);
            
        }
    }
}
