using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon1 : MonoBehaviour
{

    public Transform firePoint1;
    public GameObject bulletPrefab1;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }
    void Shoot()
    {
        Instantiate(bulletPrefab1, firePoint1.position, firePoint1.rotation);
    }
}
