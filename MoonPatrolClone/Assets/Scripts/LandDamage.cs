using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LandDamage : MonoBehaviour
{
    // Start is called before the first frame update
    public void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.name == "Player")
        {
            Destroy(col.gameObject);
        }
    }
}
