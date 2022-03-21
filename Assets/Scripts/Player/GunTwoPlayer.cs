using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunTwoPlayer : MonoBehaviour
{

    public GameObject bulletPrefabs;
    public GameObject PosGun1;
    public GameObject PosGun2;

    AudioSource aus;
    public AudioClip SoundBulletPlayer;

    //TimeSpawnBullet
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
        SpawnGunTwo();
    }

    public void SpawnGunTwo()
    {
        timer -= Time.deltaTime;

        if (timer <= 0)
        {
            Instantiate(bulletPrefabs, PosGun1.transform.position, Quaternion.identity);
            Instantiate(bulletPrefabs, PosGun2.transform.position, Quaternion.identity);
            timer = timeDuration;
        }
    }

}
