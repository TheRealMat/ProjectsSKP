﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Timer : MonoBehaviour
{
    public TextMeshPro timerText;
    private float secondsCount;
    private int minuteCount;
    private int hourCount;


    private GameManager gameManager;

    private void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
    }

    void Update()
    {
        if (gameManager.gameStarted == true && gameManager.gameOver == false)
        {
            UpdateTimerUI();
        }
    }

    public void UpdateTimerUI()
    {

        secondsCount += Time.deltaTime;
        timerText.text = hourCount + "h:" + minuteCount.ToString("00") + "m:" + ((int)secondsCount).ToString("00") + "s";
        if (secondsCount >= 60)
        {
            minuteCount++;
            secondsCount = 0;
        }
        else if (minuteCount >= 60)
        {
            hourCount++;
            minuteCount = 0;
        }
    }

}
