using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public static float currentTimeDeath = 0f;
    public float startingTimeDeath = 0f;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag.Equals("Bullet"))
        {
            ScoreScript.scoreValue += 1;
        }
    }
    public void Start()
    {
        currentTimeDeath = startingTimeDeath;
    }
    public void Update()
    {
        currentTimeDeath += 1 * Time.deltaTime;
        if (currentTimeDeath >= 8)
        {
            Destroy(this.gameObject);
        }

    }




}


