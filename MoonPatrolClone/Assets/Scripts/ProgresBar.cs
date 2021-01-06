using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ProgresBar : MonoBehaviour
{
    private Slider slider;

    public static float fillSpeed = 0.1f;
    private float targetProgress = 0;

    private void Awake()
    {
        slider = gameObject.GetComponent<Slider>();
    }
    // Start is called before the first frame update
    void Start()
    {
        IncrementProgress(5f);
    }

    // Update is called once per frame
    void Update()
    {
        if (slider.value < targetProgress)
            slider.value += fillSpeed * Time.deltaTime;
        if (slider.value >= 5)
        {
 
            SceneManager.LoadScene("Level0Breake");
            if (CountdownTimer.currentTime <= 10)
            {
                ScoreScript.scoreValue += 10;
            }

        }
    }
    public void IncrementProgress(float newProgress)
    {
        targetProgress = slider.value + newProgress;
    }
}
