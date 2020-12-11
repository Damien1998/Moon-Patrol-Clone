using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateObject : MonoBehaviour
{
    public Transform SpawnPoint;
    public GameObject Prefab;

    private float timeBtwShots;
    public float startTimeBtwShoots;
    // Start is called before the first frame update
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (timeBtwShots <= 0)
        {

            Instantiate(Prefab, SpawnPoint.position, SpawnPoint.rotation);
            timeBtwShots = startTimeBtwShoots;
        }


        else
        {
            timeBtwShots -= Time.deltaTime;
        }
        
    }
}
