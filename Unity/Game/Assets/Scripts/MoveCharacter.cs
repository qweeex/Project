using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCharacter : MonoBehaviour
{
    public float speed = 10f;
    public float acceleration = 30f;
    public float jumpforce = 5f;
    public float spd;
    Rigidbody2D rb;
    public float direction;
    Animator animator;

    float initialScaleX;
    void Awake ()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
        animator = gameObject.GetComponent<Animator>();

        initialScaleX = transform.localScale.x;
    }

    void FixedUpdate ()
    {
        var x = Input.GetAxis(axisName: "Horizontal");
        rb.AddForce(x * Vector2.right * acceleration);
        animator.SetFloat("Speed", Mathf.Abs(x));

        var Speed = Mathf.Clamp(rb.velocity.x, -speed, speed);
        rb.velocity = new Vector2(rb.velocity.x, rb.velocity.y);

        direction = Mathf.Sign(x);

        transform.localScale = new Vector3(direction * initialScaleX, transform.localScale.y, transform.localScale.z);
    }
}
