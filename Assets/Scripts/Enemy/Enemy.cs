using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enemy : MonoBehaviour
{
   
    public static Enemy insEnemy;
    Rigidbody2D rb;

    //create Health Enemy
    float maxHealth = 100f;
    public float currentHealth;


    //Create explosion Enemy when Dead
    public GameObject enemyExplosion;
    

    //Create Score
    int m_scoreText;
    UIManager m_ui;
   

    // Start is called before the first frame update

    private void Awake()
    {
        insEnemy = this;

        
    }
    void Start()
    {
        insEnemy = this;

        rb = GetComponent<Rigidbody2D>();
       
        currentHealth = maxHealth;
        

        if (this.gameObject.CompareTag("Boss1"))
        {
            currentHealth = 1000f;
        }
        else currentHealth = 100f;

        this.gameObject.SetActive(true);


    }
    // Update is called once per frame
    void Update()
    {
    
    }

    public void takeDame(float Dame)
    {

        currentHealth -= Dame;
        if (currentHealth <= 0)
        {
            enemyDeath();
        }

    }

    public void enemyDeath()
    {
        scoreText.insScore.setScore();
        Destroy(gameObject);
        Instantiate(enemyExplosion, transform.position, Quaternion.identity);
    }

}

