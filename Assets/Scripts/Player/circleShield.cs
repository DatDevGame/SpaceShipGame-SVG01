using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class circleShield : MonoBehaviour
{
    //Create Time Live of Shield
    float timer;
    protected float timeDuration;

    void Start()
    {
        timeDuration = 15f;
        timer = timeDuration;

        this.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        setShield();
    }

    public void setShield()
    {
            timer -= Time.deltaTime;
            if (timer <= 0)
            {
                this.gameObject.SetActive(false);
                timer = timeDuration;
            }
    }

}
