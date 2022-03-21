using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealingPlayer : MonoBehaviour
{
    Rigidbody2D rb;
    public float heallingPlayer;
    void Start()
    {
        Destroy(gameObject, 15);
        rb = GetComponent<Rigidbody2D>();
        heallingPlayer = 25f;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Player healPlayer = other.gameObject.GetComponent<Player>();
            healPlayer.receiveHearth(heallingPlayer);
            Destroy(gameObject);
        }
    }

}
