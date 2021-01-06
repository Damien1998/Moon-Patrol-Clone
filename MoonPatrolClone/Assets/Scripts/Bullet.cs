using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed;
    public Rigidbody2D rb;
    public float lifeTime;
    public float distance;
    public int damage;
    public LayerMask whatIsSolid;
  
    //public GameObject destroyEffect;

    private void Start()
    {
        rb.velocity = transform.right * speed;
        Invoke("DestroyBullet", lifeTime);
    }
    private void Update()
    {
       
    }
    void DestroyBullet()
    {
        //Instantiate(destroyEffect, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Enemy")
        {
            Destroy(other.gameObject);
            Destroy(this.gameObject);
        }
    }
}
