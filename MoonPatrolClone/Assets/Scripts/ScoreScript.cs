using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{
    public static int scoreValue = 0;
    Text score;
    
    // Start is called before the first frame update
    public void Start()
    {
        score = GetComponent<Text>();
    }

    // Update is called once per frame

 
    public void Update()
    {
        score.text = "Score" + scoreValue;
        if(scoreValue > PlayerPrefs.GetInt("highestscore"))
        {
            PlayerPrefs.SetInt("highestscore", scoreValue);
        }
        
    }
    
}
