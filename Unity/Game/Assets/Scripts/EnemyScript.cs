using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    public float MaxSpeed = 2f;
    public float Acceleration = 1f;

    Rigidbody2D rb;
    float moveDirection = 1f;

    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
    }

    void Update()
    {

    }

    void FixedUpdate()
    {
        rb.AddForce(moveDirection * Vector2.right * Acceleration);

        var speed = Mathf.Clamp(rb.velocity.x, -MaxSpeed, MaxSpeed);
        rb.velocity = new Vector2(speed, rb.velocity.y);
  
        
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Barrier")
        {
            transform.localScale = new Vector3(-transform.localScale.x, transform.localScale.y, transform.localScale.z);
            moveDirection = -moveDirection;
        }
    }
}
