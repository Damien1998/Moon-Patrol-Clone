﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] enemies;
    public Vector3 spawnValues;
    public int rangestart = 0;
    public int rangeend = 6;
    public float spawnWait;
    public float spawnMostWait;
    public float spawnLeastWait;
    public int startWait;
    public bool stop;

    int randEnemy;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(waitSpawner());
    }

    // Update is called once per frame
    void Update()
    {
        spawnWait = Random.Range(spawnLeastWait, spawnMostWait);
    }

    IEnumerator waitSpawner()
    {
        yield return new WaitForSeconds(startWait);
        while (!stop)
        {
            randEnemy = Random.Range(rangestart, rangeend);
            Vector3 spawnPosition = new Vector3(1, 1,0);
            Instantiate(enemies[randEnemy], spawnPosition + transform.TransformPoint(0,0, 0), gameObject.transform.rotation);
            yield return new WaitForSeconds(spawnWait);

        }
    }

}

