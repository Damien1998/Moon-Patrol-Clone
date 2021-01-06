using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LandDamage : MonoBehaviour
{
    public GameObject respawn;
    // Start is called before the first frame update
    public void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.name == "Player")
        {
            Destroy(col.gameObject);
            Instantiate(respawn);
            Lives.livesValue -= 1;
            ProgresBar.fillSpeed = 0f;
        }
    }
}
