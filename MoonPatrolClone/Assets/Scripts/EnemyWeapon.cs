﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyWeapon : MonoBehaviour
{
    public Transform EnemyGun;
    public GameObject Prefab;

    private float timeBtwShots;
    public float startTimeBtwShoots;

    //private float timeBtwShots;
    //public float startTimeBtwShoots;

    // Start is called before the first frame update
    void OnTriggerEnter2d(Collider2D other)
    {
        if (timeBtwShots <= 0)
        {
            if (other.gameObject.tag == "Player")
            {
                Instantiate(Prefab, EnemyGun.position, transform.rotation);
            }
        }
        else
        {
            timeBtwShots -= Time.deltaTime;
        }


    }
    
}

   
