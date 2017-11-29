using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedUp : MonoBehaviour {

    GameObject player;
    PlayerMovement playermovement;
    Renderer rend;
    AudioSource Audio;
    Transform speedup;
    public bool active=true;
    // Use this for initialization
    void Start()
    {

        player = GameObject.FindGameObjectWithTag("Player");

        playermovement = player.GetComponent<PlayerMovement>();

        rend = GetComponent<Renderer>();

        Audio = GetComponent<AudioSource>();

        speedup = GetComponent<Transform>();

        
    }

    // Update is called once per frame
    void Update()
   {
        transform.Rotate(0, 5, 0, 0);

       
    }



    IEnumerator OnTriggerEnter(Collider other)
    {
        

        if (other.gameObject.CompareTag("Player")&&active)
        {

            playermovement.speed =12;
          
            Audio.Play();

            active=false;

            rend.enabled = false;

            yield return new WaitForSeconds(10.0f);

            playermovement.speed = 6;

           

            //yield return new WaitForSeconds(5.0f);

            Object.Destroy(gameObject);

        }
    }
}
