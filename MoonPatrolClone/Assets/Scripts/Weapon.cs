using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public Transform FirePoint;
    public GameObject BulletPrefab;

    private float timeBtwShots;
    public float startTimeBtwShoots;

    private void Update()
    {

        if (timeBtwShots <= 0)
        {
            if (Input.GetMouseButtonDown(0))
            {
                Instantiate(BulletPrefab, FirePoint.position, transform.rotation);
                timeBtwShots = startTimeBtwShoots;
            }
        }
        else
        {
            timeBtwShots -= Time.deltaTime;
        }
        
    }
}
