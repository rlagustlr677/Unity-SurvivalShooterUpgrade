using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Stagemanager : MonoBehaviour {

    int stage;
    Text text;
    Renderer rend;
    int stage_count;
    GameObject Enemy;
    EnemyManager enemy;
    Material my;
    // Use this for initialization
    void Awake () {

        text = GetComponent<Text>();
        stage = 0;
        stage_count = 1;
        Enemy = GameObject.FindGameObjectWithTag("Enemy");
        enemy = Enemy.GetComponent<EnemyManager>();
        
    }
	
	// Update is called once per frame
	void Update () {
        if (ScoreManager.score >= 0&& stage_count == 1)
        {
            myf();
            stage_count++;
            
        }
        if (ScoreManager.score >= 50&&stage_count==2)
        {
            myf();
            stage_count++;
        }
        if (ScoreManager.score > 200 && stage_count == 3)
        {
            myf();
            stage_count++;
        }
        if (ScoreManager.score > 550 && stage_count == 4)
        {
            myf();
            stage_count++;
        }
        if (ScoreManager.score > 1000 && stage_count == 5)
        {
            myf();
            stage_count++;
        }
        if (ScoreManager.score > 2000 && stage_count == 6)
        {
            myf();
            stage_count++;
        }
        if(ScoreManager.score > 4000 && stage_count == 7)
        {
            text.text = "Final Stage";
        }
    }

    void myf()
    {
        stage++;
        text.text = "Stage " + stage;
        
    }

   
}
