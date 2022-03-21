using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletBlueBoss2 : MonoBehaviour
{
    public GameObject BulletPrefab;

    public Transform PosGun1;
    public Transform PosGun2;
    public Transform PosGun3;
    public Transform PosGun4;
    public Transform PosGun5;
    public Transform PosGun6;
    public Transform PosGun7;
    public Transform PosGun8;
    public Transform PosGun9;

    float timer;
    protected float timeDuration;

    float timerDelay;
    protected float timerDurationDelay;



    // Start is called before the first frame update
    void Start()
    {
        timeDuration = 22f;
        timer = timeDuration;

    }

    // Update is called once per frame
    void Update()
    {
        spawnBulletBoss();
    }

    public void spawnBulletBoss()
    {
        timer -= Time.deltaTime;
        if (timer <= 0)
        {
            Instantiate(BulletPrefab, PosGun1.transform.position, PosGun1.transform.rotation);
            Instantiate(BulletPrefab, PosGun2.transform.position, PosGun2.transform.rotation);
            Instantiate(BulletPrefab, PosGun3.transform.position, PosGun3.transform.rotation);
            Instantiate(BulletPrefab, PosGun4.transform.position, PosGun4.transform.rotation);
            Instantiate(BulletPrefab, PosGun5.transform.position, PosGun5.transform.rotation);
            Instantiate(BulletPrefab, PosGun6.transform.position, PosGun6.transform.rotation);
            Instantiate(BulletPrefab, PosGun7.transform.position, PosGun7.transform.rotation);
            Instantiate(BulletPrefab, PosGun8.transform.position, PosGun8.transform.rotation);
            Instantiate(BulletPrefab, PosGun9.transform.position, PosGun9.transform.rotation);

            timer = timeDuration;
        }

    }
}
