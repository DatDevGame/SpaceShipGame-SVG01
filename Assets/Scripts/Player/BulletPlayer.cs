using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletPlayer : MonoBehaviour
{

    public Transform PosGun;
    public GameObject bulletPrefab;
    float timer;
    public float timerDuration;


    void Start()
    {
        this.timer = timerDuration;
    }

    // Update is called once per frame
    void Update()
    {
        prefabBullet();
    }

    public void prefabBullet()
    {
        this.timer -= Time.deltaTime;
        if (timer <= 0)
        {
            Instantiate(bulletPrefab, PosGun.position, PosGun.transform.rotation);
            timer = timerDuration;
        }
       
    }

}
