using UnityEngine;

public class GameOverManager : MonoBehaviour
{
    public PlayerHealth playerHealth;
    public GameObject enemy;
    int count = 0;
    Animator anim;
    Animator anim2;


    void Awake()
    {
        anim = GetComponent<Animator>();
        anim2 = GetComponent<Animator>();

        enemy = GameObject.FindWithTag("Enemy");
    }


    void Update()
    {
        if (playerHealth.currentHealth <= 0)
        {
            anim.SetTrigger("GameOver");
            
        }
        else if (ScoreManager.score >= 10000)
        {
            anim2.SetTrigger("GameClear");
            if (count == 0)
            {

                playerHealth.Death();
                count++;

            }
        }
        
    }
}
