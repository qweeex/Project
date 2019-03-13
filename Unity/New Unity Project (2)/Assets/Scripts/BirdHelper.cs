using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdHelper : MonoBehaviour
{

    public float speed = 5f;
    public float accseleration = 4f;
    public float force = 2f;

    private int x = -1;

    Rigidbody2D rb;

    void Start ()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
    }

    void FixedUpdate ()
    {
        rb.AddForce(x * Vector2.right * accseleration);
        var Speed = Mathf.Clamp(rb.velocity.x, -speed, speed);
        rb.velocity = new Vector2(Speed, rb.velocity.y);
    }

    void OnCollisionEnter2D (Collision2D collision)
    {
        if(collision.transform.tag == "Finish")
        {
            x *= -1 ;
        }

        if (collision.transform.tag == "Player")
        {
            rb.AddForce(transform.right * force, ForceMode2D.Impulse);
        }
    }
}
