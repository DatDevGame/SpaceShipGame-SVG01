using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunManager : MonoBehaviour
{
    public GameObject setActiveGunOne;
    public GameObject setActiveGunTwo;
    public GameObject setActiveGunthree;
    public GameObject setActiveGunFour;
    public GameObject setActiveGunFive;

    public GameObject RocketPrefab;
    public Transform PosRocket;

    int currentGun = 1;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnTriggerEnter2D(Collider2D other)
    {


        //Set active Level Gun
        if (other.gameObject.CompareTag("ItemBullet"))
        {
            currentGun += 1;
            if (currentGun >= 5) currentGun = 5;
            if (currentGun == 1)
            {
                setActiveGunOne.SetActive(true);
            }
            if (currentGun == 2)
            {
                setActiveGunOne.SetActive(false);
                setActiveGunTwo.SetActive(true);
            }
            if (currentGun == 3)
            {
                setActiveGunTwo.SetActive(false);
                setActiveGunthree.SetActive(true);
            }
            if (currentGun == 4)
            {
                setActiveGunthree.SetActive(false);
                setActiveGunFour.SetActive(true);
            }
            if (currentGun == 5)
            {
                setActiveGunFour.SetActive(false);
                setActiveGunFive.SetActive(true);
            }
        }
            

        if (other.gameObject.CompareTag("BulletEnemy"))
        {
            if (currentGun == 5)
            {
                setActiveGunFive.SetActive(false);
                setActiveGunFour.SetActive(true);
            }
            if (currentGun == 4)
            {
                setActiveGunFour.SetActive(false);
                setActiveGunthree.SetActive(true);
            }
            if (currentGun == 3)
            {
                setActiveGunthree.SetActive(false);
                setActiveGunTwo.SetActive(true);
            }
            if (currentGun == 2)
            {
                setActiveGunTwo.SetActive(false);
                setActiveGunOne.SetActive(true);
            }
            currentGun -= 1;
            if (currentGun <= 1) currentGun = 1;
        }
    }
}
