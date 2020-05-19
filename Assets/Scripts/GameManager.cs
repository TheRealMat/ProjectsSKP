using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    bool gameEnded;
    public GameObject gameOverSceen;
    public GameObject mainMenuScreen;

    public bool gameOver;

    public void StartGame()
    {
        mainMenuScreen.SetActive(false);
    }

    public void EndGame()
    {
        gameOver = true;
        gameOverSceen.SetActive(true);
    }
}
