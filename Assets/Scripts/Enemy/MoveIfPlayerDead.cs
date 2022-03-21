using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveIfPlayerDead : MonoBehaviour
{
    protected float speed;
    Vector2 moveEnemy = new Vector2();
    void Start()
    {
        speed = 5f;
    }

    // Update is called once per frame
    void Update()
    {
        MoveEnemyWhenPlayerDead();
    }

    public void MoveEnemyWhenPlayerDead()
    {
        
        //Move Enemy When Player Dead

        if (Player.ins.currentHealthPlayer <= 0)
        {
            moveEnemy = Vector2.down * speed * Time.deltaTime;
            transform.Translate(moveEnemy);
            Destroy(gameObject, 4);
        }
    }
}
