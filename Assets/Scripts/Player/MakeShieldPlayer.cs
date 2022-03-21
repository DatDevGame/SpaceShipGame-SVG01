using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakeShieldPlayer : MonoBehaviour
{
    protected GameObject posPlayer;
    public GameObject shieldPrefab;
    void Start()
    {
        posPlayer = GameObject.Find("Player");
        Instantiate(shieldPrefab, transform.position, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("ItemShield"))
        {
            Instantiate(shieldPrefab, posPlayer.transform.position, Quaternion.identity);
        }
    }
}
