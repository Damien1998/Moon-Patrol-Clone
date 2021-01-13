using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Respawn : MonoBehaviour
{
    public float startTime;
    public float currentTime;
    // Start is called before the first frame update
    void Start()
    {
        currentTime = startTime;
    }

    // Update is called once per frame
    void Update()
    {
        currentTime += 1 * Time.deltaTime;
        if (currentTime >= 3)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            ProgresBar.fillSpeed = 1f;
        }
    }
}
