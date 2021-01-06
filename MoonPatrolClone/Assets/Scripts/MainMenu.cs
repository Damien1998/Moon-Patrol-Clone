using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void playGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        Lives.livesValue = 3;
        ScoreScript.scoreValue = 0;
    }
    public void quitGame()
    {
        Application.Quit();
    }
    public void contineGame()
    {
        SceneManager.LoadScene("Level1");
    }
}

