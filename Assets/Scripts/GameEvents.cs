using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class GameEvents : MonoBehaviour
{
    public event Action<int> onMinuteChanged;
    public void MinuteChanged(int minute)
    {
        if (onMinuteChanged != null)
        {
            onMinuteChanged(minute);
        }
    }

    public event Action onGameOver;
    public void GameOver()
    {
        if (onGameOver != null)
        {
            onGameOver();
        }
    }

    public event Action onGameWon;
    public void GameWon()
    {
        if (onGameWon != null)
        {
            onGameWon();
        }
    }
}
