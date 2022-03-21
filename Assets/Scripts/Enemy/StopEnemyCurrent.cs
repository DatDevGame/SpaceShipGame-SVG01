using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopEnemyCurrent : MonoBehaviour
{
    public static StopEnemyCurrent ins;

    Rigidbody2D rb;
    //create Move
    public float moveSpeed = 1f;
    Vector2 moveEnemy = new Vector2(0f, -1f);

    //random Stop Enemy
    float timer;
    protected float timeDuration;

    private void Awake()
    {
        ins = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        //random Stop Enemy
        timeDuration = Random.Range(2, 5);
        timer = timeDuration;

        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        moveEnemyDown();
        randomPosYEnemy();
    }
    public void moveEnemyDown()
    {
        this.rb.position += moveEnemy * moveSpeed * Time.deltaTime;
    }

    //random Stop Enemy
    public void randomPosYEnemy()
    {
        timer -= Time.deltaTime;
        if (timer <= 0)
        {
            this.enabled = false;
        }

    }
}
