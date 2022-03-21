using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunThreePlayer : MonoBehaviour
{
    public GameObject PosGunThree1;
    public GameObject PosGunThree2;
    public GameObject PosGunThree3;

    public GameObject bulletPrefabs;

    float timer;
    protected float timeDuration;

    void Start()
    {
        this.gameObject.SetActive(false);
        timeDuration = 0.2f;
        timer = timeDuration;
    }

    // Update is called once per frame
    void Update()
    {
        SpawnGunThree();
    }

    public void SpawnGunThree()
    {
        timer -= Time.deltaTime;

        if (timer <= 0)
        {
            Instantiate(bulletPrefabs, PosGunThree1.transform.position, PosGunThree1.transform.rotation);
            Instantiate(bulletPrefabs, PosGunThree2.transform.position, PosGunThree2.transform.rotation);
            Instantiate(bulletPrefabs, PosGunThree3.transform.position, PosGunThree3.transform.rotation);
            timer = timeDuration;
        }
    }

}
