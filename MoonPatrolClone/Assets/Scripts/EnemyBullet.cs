using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet : MonoBehaviour
{
    public Rigidbody2D rb;
    public LayerMask whatIsSolid;
    public float lifeTime;
    public GameObject respawn;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("DestroyBullet", lifeTime);
    }

    // Update is called once per frame
    void DestroyBullet()
    {
        //Instantiate(destroyEffect, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            Destroy(other.gameObject);
            Destroy(this.gameObject);
            Instantiate(respawn);
            Lives.livesValue -= 1;
            ProgresBar.fillSpeed = 0f;
        }
    }
}
