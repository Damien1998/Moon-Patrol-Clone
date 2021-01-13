using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Reload : MonoBehaviour
{
    
    public void Update()
    {
       if (Input.GetKeyDown(KeyCode.Escape))
        {
            //Application.LoadLevel(Application.loadedLevel);
            ScoreScript.scoreValue = 0;
            SceneManager.LoadScene("Menu");
        }
      
    }

}
