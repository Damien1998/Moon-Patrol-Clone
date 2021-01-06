using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Lives : MonoBehaviour
{
    public static int livesValue = 3;
    Text lives;
    // Start is called before the first frame update
    void Start()
    {
        lives = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        lives.text = "Lives" + livesValue;
        if (livesValue == 0)
        {
            //ScoreScript.scoreValue = 0;
            SceneManager.LoadScene("Menu");
        }
    }
}
