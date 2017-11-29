using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoewrUp : MonoBehaviour {

    
    GameObject Gundamage;
    PlayerShooting playerpower;
    LineRenderer Linepower;
    Renderer rend;
    AudioSource Audio;
    public bool active = true;
    // Use this for initialization
    void Start()
    {
        Gundamage = GameObject.FindGameObjectWithTag("GunBarrel"); 

        playerpower = Gundamage.GetComponent<PlayerShooting>();

        Linepower = Gundamage.GetComponent<LineRenderer>();

        rend = GetComponent<Renderer>();

        Audio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 5, 0, 0);
    }

    IEnumerator OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player") && active)
        {

            SetLineplus();

            active = false;

            rend.enabled = false;
           
            yield return new WaitForSeconds(10.0f);

            SetLine();
         
            Object.Destroy(gameObject);

        }
    }

    void SetLineplus()
    {

        Audio.Play();

        playerpower.damagePerShot = 50;

        playerpower.timeBetweenBullets = 0.075f;

        Linepower.SetWidth(0.1f, 0.1f);
      
    }

    void SetLine()
    {
        playerpower.damagePerShot = 20;

        playerpower.timeBetweenBullets = 0.15f;

        Linepower.SetWidth(0.05f, 0.05f);
    }
}
