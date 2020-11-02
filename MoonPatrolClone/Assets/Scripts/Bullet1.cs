using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet1 : MonoBehaviour
{
    public float speed = 20f;
    public Rigidbody2D rb;
    public int damage = 1;

    // Start is called before the first frame update
    void Start()
    {
        rb.velocity = transform.right * speed;
    }

    private void OnTriggerEnter2D(Collider2D hitInfo)
    {
        Rock rock = hitInfo.GetComponent<Rock>();
        if (rock != null)
        {
            rock.TakeDamage(damage);
        }
        Destroy(gameObject);
    }

}
