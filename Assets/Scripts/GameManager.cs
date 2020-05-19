using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    bool gameEnded;
    public GameObject gameOverSceen;


    public void GameOver()
    {
        gameOverSceen.SetActive(true);
    }
}
