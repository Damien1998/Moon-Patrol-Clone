using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Highestsscore : MonoBehaviour
{
    public Text HighestScore;
    // Start is called before the first frame update
    void Start()
    {
       
        HighestScore.text = PlayerPrefs.GetInt("highestscore").ToString();
    }

   
}
