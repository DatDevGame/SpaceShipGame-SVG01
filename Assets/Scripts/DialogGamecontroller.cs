using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DialogGamecontroller : MonoBehaviour
{

    public GameObject showCanvas;

    public GameObject showWingame;
    public GameObject BossDead;
    AudioSource aus;

    float timer;
    void Start()
    {
        timer = 2f;
        aus = GetComponent<AudioSource>();
    }

    
    void Update()
    {
        setCanvas();
        showPanelWingame();
    }

    public void ReplayBtn()
    {
        SceneManager.LoadScene("PlayerScene");
    }

    public void backOption()
    {
        SceneManager.LoadScene("OptionScene");
    }

    public void setCanvas()
    {
        if (Player.ins.currentHealthPlayer <= 0)
        {
            showCanvas.SetActive(true);
        }
    }

    public void showPanelWingame()
    {
        if (BossDead == null)
        {
            timer -= Time.deltaTime;
            if (timer > 0)
            {
                return;
            }
            else
            {
                showWingame.SetActive(true);
                Time.timeScale = 0f;
            } 
        }
    }
}
