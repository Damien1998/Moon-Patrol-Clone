using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon1 : MonoBehaviour
{

    public Transform FirePoint1;
    public GameObject BulletPrefab1;

    private float timeBtwShots;
    public float startTimeBtwShoots;

    private void Update()
    {

        if (timeBtwShots <= 0)
        {
            if (Input.GetMouseButtonDown(0))
            {
                Instantiate(BulletPrefab1, FirePoint1.position, transform.rotation);
                timeBtwShots = startTimeBtwShoots;
            }
        }
        else
        {
            timeBtwShots -= Time.deltaTime;
        }

    }
}
