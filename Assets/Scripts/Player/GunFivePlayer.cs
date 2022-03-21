using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunFivePlayer : MonoBehaviour
{
    public GameObject GunFive1;
    public GameObject GunFive2;
    public GameObject GunFive3;
    public GameObject GunFive4;
    public GameObject GunFive5;

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
            Instantiate(bulletPrefabs, GunFive1.transform.position, GunFive1.transform.rotation);
            Instantiate(bulletPrefabs, GunFive2.transform.position, GunFive2.transform.rotation);
            Instantiate(bulletPrefabs, GunFive3.transform.position, GunFive3.transform.rotation);
            Instantiate(bulletPrefabs, GunFive4.transform.position, GunFive4.transform.rotation);
            Instantiate(bulletPrefabs, GunFive5.transform.position, GunFive5.transform.rotation);

            timer = timeDuration;
        }

    }
}
