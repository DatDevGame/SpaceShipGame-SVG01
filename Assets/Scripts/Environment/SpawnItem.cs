using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnItem : MonoBehaviour
{
    //Create Item
    public GameObject healItem;
    public GameObject ShieldItem;
    public GameObject BulletItem;

    //SpawnItemHeal
    float timer;
    protected float timeDuration;

    //SpawnItemShield
    float timer2;
    protected float timeDuration2;

    //SpawnItemBullet
    float timer3;
    protected float timeDuration3;



    // Start is called before the first frame update
    void Start()
    {
        timeDuration = Random.Range(20, 50);
        timer = timeDuration;

        timeDuration2 = Random.Range(50, 70);
        timer2 = timeDuration2;

        timeDuration3 = Random.Range(40, 100);
        timer3 = timeDuration2;
    }

    // Update is called once per frame
    void Update()
    {
        spawnHealItem();
        spawnShieldItem();
        spawnBulletItem();
    }

    public void spawnHealItem()
    {
        float randXPos = Random.Range(-8f, 8f);
        Vector2 spawnPosHeal = new Vector2(randXPos, 2f);

        timer -= Time.deltaTime;
        if (timer <= 0)
        {
            Instantiate(healItem, spawnPosHeal, Quaternion.identity);
            timer = timeDuration;
        }
    }

    public void spawnShieldItem()
    {
        float randXPos = Random.Range(-8f, 8f);
        Vector2 spawnPosShield = new Vector2(randXPos, 2f); 

        timer2 -= Time.deltaTime;
        if (timer2 <= 0)
        {
            Instantiate(ShieldItem, spawnPosShield, Quaternion.identity);
            timer2 = timeDuration2;
        }
    }

    public void spawnBulletItem()
    {
        float randXPos = Random.Range(-8f, 8f);
        Vector2 spawnPosBullet = new Vector2(randXPos, 2f);

        timer3 -= Time.deltaTime;
        if (timer3 <= 0)
        {
            Instantiate(BulletItem, spawnPosBullet, Quaternion.identity);
            timer3 = timeDuration3;
        }
    }

}
