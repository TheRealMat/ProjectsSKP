using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int minutesToWin;

    bool gameEnded;
    public GameObject gameOverSceen;
    public GameObject mainMenuScreen;
    public GameObject winScreen;

    public bool gameOver;
    public bool gameStarted;
    public bool gameWon;

    private void Start()
    {
        GameObject.FindObjectOfType<GameEvents>().onMinuteChanged += CheckIfWon;
        GameObject.FindObjectOfType<GameEvents>().onGameWon += WinGame;
        GameObject.FindObjectOfType<GameEvents>().onGameOver += EndGame;

    }


    public void StartGame()
    {
        gameStarted = true;
    }

    public void EndGame()
    {
        gameOver = true;
    }

    public void WinGame()
    {
        gameWon = true;
    }

    private void CheckIfWon(int minute)
    {
        if (minute >= minutesToWin)
        {
            WinGame();
            GameObject.FindObjectOfType<GameEvents>().GameWon();
        }
    }
}
