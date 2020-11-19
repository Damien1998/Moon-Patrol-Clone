using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Rigidbody2D rb2d;
    public float moveSpeed = 5f;
    public float jumpHight = 5f;
    public bool isGrounded = false;
    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
       
        Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), 0f, 0f)*moveSpeed;
        //transform.position += movement * Time.deltaTime * moveSpeed;
        Vector3 vel = rb2d.velocity;
        vel.x = movement.x;
        vel.z = movement.z;
        rb2d.velocity = vel;
        Jump();
    }
    void Jump()
    {
        if (Input.GetButtonDown("Jump") && isGrounded == true)
        {
            rb2d.AddForce(new Vector2(0f, jumpHight), ForceMode2D.Impulse);
        }
    }
}
