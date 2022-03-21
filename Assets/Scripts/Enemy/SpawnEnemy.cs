using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{

    public GameObject enemyPrefabs1;

    public GameObject enemyPrefabs2;

    public GameObject enemyPrefabs3;

    public GameObject BossPrefabs;

    //check limit Enemy

    //time Spawn
    float timer;
    public float timeDuration;

    float timerBoss;
    protected float timeDurationBoss;


    // Start is called before the first frame update
    void Start()
    {
        timer = timeDuration;

        timeDurationBoss = 1f;
        timerBoss = timeDurationBoss;

    }

    // Update is called once per frame
    void Update()
    {
        spawnEnemy1();
        SpawnEnemy2();
        SpawnEnemy3();
        SpawnBoss();
    }

    public void spawnEnemy1()
    {
    
        if (scoreText.insScore.m_Score < 100 || scoreText.insScore.m_Score >= 150 && scoreText.insScore.m_Score < 200)
        {
            //Spawn enemy -8x   -   8x
            float randXpos = Random.Range(-8f, 8f);
            if (Player.ins.currentHealthPlayer <= 0) return;


            Vector2 posSpawn = new Vector2(randXpos, 2.5f);

            timer -= Time.deltaTime;
            if (timer <= 0)
            {
                Instantiate(enemyPrefabs1, posSpawn, Quaternion.identity);
                timer = timeDuration;
            }
        }

    }
    public void SpawnEnemy2()
    {
        if (scoreText.insScore.m_Score > 50 && scoreText.insScore.m_Score <= 100 || scoreText.insScore.m_Score >= 150 && scoreText.insScore.m_Score < 200)
        {
            //Spawn enemy -8x   -   8x
            float randXpos = Random.Range(-8f, 8f);
            if (Player.ins.currentHealthPlayer <= 0) return;
            Vector2 posSpawn = new Vector2(randXpos, 2.5f);

            timer -= Time.deltaTime;
            if (timer <= 0)
            {
                Instantiate(enemyPrefabs2, posSpawn, Quaternion.identity);
                timer = timeDuration;
            }
        }
    }


    public void SpawnEnemy3()
    {
        if (scoreText.insScore.m_Score > 100 && scoreText.insScore.m_Score < 200)
        {
            //Spawn enemy -8x   -   8x
            float randXpos = Random.Range(-8f, 8f);
            if (Player.ins.currentHealthPlayer <= 0) return;
            Vector2 posSpawn = new Vector2(randXpos, 2.5f);

            timer -= Time.deltaTime;
            if (timer <= 0)
            {
                Instantiate(enemyPrefabs3, posSpawn, Quaternion.identity);
                timer = timeDuration;
            }
        }
    }

    public void SpawnBoss()
    {
        if (scoreText.insScore.m_Score > 200)
        {
            BossPrefabs.SetActive(true);
        }
    }


}
