using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet1 : MonoBehaviour
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
        rb.velocity = transform.up * speed;
        Invoke("DestroyBullet", lifeTime);
    }
    private void Update()
    {
        //RaycastHit2D hitInfo = Physics2D.Raycast(transform.position, transform.right, distance);
        //{
        //    if (hitInfo.collider != null)
        //    {
        //        if (hitInfo.collider.CompareTag("Enemy"))
        //        {
        //            hitInfo.collider.GetComponent<Enemy>().TakeDamage(damage);
        //            DestroyBullet();
        //        }

        //    }
        //}
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
