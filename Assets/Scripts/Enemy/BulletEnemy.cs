using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletEnemy : MonoBehaviour
{
    public GameObject bulletEnemyPrefab;
    public Transform PosGunEnemy;
    protected float timer;
    protected float timeDuration;

    private void Start()
    {
        timeDuration = Random.Range(2f, 5f);
        timer = timeDuration;
    }
    private void Update()
    {
        prefabsBullet();
    }

    public void prefabsBullet()
    {
        //Stop spawn Bullt Enemy When Player Dead
        if (Player.ins.currentHealthPlayer <= 0)
            return;

        timer -= Time.deltaTime;
        if (timer <= 0)
        {
            Instantiate(bulletEnemyPrefab, PosGunEnemy.position, Quaternion.identity);
            timer = timeDuration;
        }

    }

}
