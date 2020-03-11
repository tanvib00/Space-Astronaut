using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public float timer; // time remaining
    public int Minutes = 0;
    public int Seconds = 60;
    public Text timertext;
    private bool lost = false;
    MazeMgr boss;
    void Start()
    {
        boss = GameObject.FindObjectOfType<MazeMgr>();
        timertext = GetComponent<Text>();
        timer = GetInitialTime();
    }

    void Update()
    {
        timer -= Time.deltaTime;

        if ((timer <= 0.0f) && !boss.gameWon) {
            timertext.text = "Time : 0:00";
            boss.gameOver = true;
        }

        if (boss.gameWon) {
            timertext.text = "";
        }
        else if (!boss.gameOver && !lost) {
            Minutes = GetLeftMinutes();
            Seconds = GetLeftSeconds();
            timertext.text = "Time : " + Minutes + ":" + Seconds.ToString("00");
        }
        else if (boss.gameOver) {
            lost = true;
        }
        if (lost) {
            timertext.text = "";
        }
    }

    private float GetInitialTime()
    { return Minutes * 60f + Seconds; }
    private int GetLeftMinutes()
    { return Mathf.FloorToInt(timer / 60f); }
    private int GetLeftSeconds() 
    { return Mathf.FloorToInt(timer % 60f); }
}
