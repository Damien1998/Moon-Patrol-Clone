using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void playGame()
    {
        SceneManager.LoadScene("Level0");
        Lives.livesValue = 3;
        ScoreScript.scoreValue = 0;
    }
    public void quitGame()
    {
        Application.Quit();
    }
    public void contineGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        CountdownTimer.currentTime = 0f;
    }
}

