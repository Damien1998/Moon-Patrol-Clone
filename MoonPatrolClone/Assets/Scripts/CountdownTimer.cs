using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountdownTimer : MonoBehaviour
{
    public static float currentTime = 0f;
    public float startingTime = 0f;
    public Text CountdownText;


    public void Start()
    {
        currentTime = startingTime;
    }
    public void Update()
    {
        currentTime += 1 * Time.deltaTime;
        CountdownText.text = currentTime.ToString("0");
    }
}
