using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManagerGunLazer : MonoBehaviour
{

    public GameObject LazerPrefab;
    public Transform PosGunLazer1;
    public Transform PosGunLazer2;
    public Transform PosGunLazer3;

    float timer;
    protected float timerDuration;
    // Start is called before the first frame update
    void Start()
    {
        timerDuration = 30f;
        timer = timerDuration;
    }

    // Update is called once per frame
    void Update()
    {
        SpawnLazer();
    }

    public void SpawnLazer()
    {
        timer -= Time.deltaTime;
        if (timer <= 0)
        {
            Instantiate(LazerPrefab, PosGunLazer1.transform.position, PosGunLazer1.transform.rotation);
            Instantiate(LazerPrefab, PosGunLazer2.transform.position, PosGunLazer2.transform.rotation);
            Instantiate(LazerPrefab, PosGunLazer3.transform.position, PosGunLazer3.transform.rotation);
            timer = timerDuration;
        }
    }
}
