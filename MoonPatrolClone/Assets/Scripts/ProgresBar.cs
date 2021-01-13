using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ProgresBar : MonoBehaviour
{
    private Slider slider;

    public static float fillSpeed = 1f;
    public int bonustime = 10;
    private float targetProgress = 0f;
    public float IncrementProgressValue = 15f;

    private void Awake()
    {
        slider = gameObject.GetComponent<Slider>();
    }
    // Start is called before the first frame update
    void Start()
    {
        IncrementProgress(IncrementProgressValue);
    }

    // Update is called once per frame
    void Update()
    {
        if (slider.value < targetProgress)
            slider.value += fillSpeed * Time.deltaTime;
        if (slider.value >= IncrementProgressValue)
        {
 
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            if (CountdownTimer.currentTime <= bonustime)
            {
                ScoreScript.scoreValue += 30;
            }

        }
    }
    public void IncrementProgress(float newProgress)
    {
        targetProgress = slider.value + newProgress;
    }
}
