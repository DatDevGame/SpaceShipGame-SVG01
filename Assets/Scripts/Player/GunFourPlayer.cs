using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunFourPlayer : MonoBehaviour
{
    public GameObject GunFour1;
    public GameObject GunFour2;
    public GameObject GunFour3;
    public GameObject GunFour4;

    public GameObject bulletPrefabs;

    float timer;
    protected float timeDuration;
    // Start is called before the first frame update
    void Start()
    {
        this.gameObject.SetActive(false);
        timeDuration = 0.2f;
        timer = timeDuration;
    }

    // Update is called once per frame
    void Update()
    {
        SpawnBulletGun();
    }

    public void SpawnBulletGun()
    {
        timer -= Time.deltaTime;
        if (timer <= 0)
        {
            Instantiate(bulletPrefabs, GunFour1.transform.position, GunFour1.transform.rotation);
            Instantiate(bulletPrefabs, GunFour2.transform.position, GunFour2.transform.rotation);
            Instantiate(bulletPrefabs, GunFour3.transform.position, GunFour3.transform.rotation);
            Instantiate(bulletPrefabs, GunFour4.transform.position, GunFour4.transform.rotation);

            timer = timeDuration;
        }
        
    }
}
