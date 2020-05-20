using System.Collections;
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

    public int minutesToWin;
    private int minutesElapsed;


    private GameManager gameManager;

    private BugSplatter bugSplatter;

    private void Start()
    {
        gameManager = FindObjectOfType<GameManager>();

        bugSplatter =  GameObject.FindObjectOfType<BugSplatter>();
    }

    void Update()
    {
        if (gameManager.gameStarted == true && gameManager.gameOver == false)
        {
            UpdateTimerUI();

            if (minutesElapsed >= minutesToWin && gameManager.gameWon == false)
            {
                gameManager.WinGame();
            }
        }

        // probably shouldn't be here.
        if (minutesElapsed >= bugSplatter.minutesToSplatter && bugSplatter.bugSplatted == false)
        {
            bugSplatter.Splat();
        }
    }

    public void UpdateTimerUI()
    {

        secondsCount += Time.deltaTime;
        timerText.text = hourCount + "h:" + minuteCount.ToString("00") + "m:" + ((int)secondsCount).ToString("00") + "s";
        if (secondsCount >= 60)
        {
            minuteCount++;
            minutesElapsed++;
            secondsCount = 0;
        }
        else if (minuteCount >= 60)
        {
            hourCount++;
            minuteCount = 0;
        }
    }

}
