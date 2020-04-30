using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        // simply advances scenes ordered in build settings by 1
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
