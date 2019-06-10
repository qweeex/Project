using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MoveCharacter : MonoBehaviour
{
    public float speed = 10f;
    public float acceleration = 30f;
    public float jumpforce = 5f;
    public float dashforce = 50f;
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

        if (Input.GetKeyDown(KeyCode.Space))
        {
            animator.SetTrigger("jump");
            rb.AddForce(Vector2.up * jumpforce, ForceMode2D.Impulse);
        }

        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            animator.SetTrigger("attack");
        }
        if (Input.GetKeyDown(KeyCode.Mouse1))
        {
            animator.SetTrigger("attack1");
            if (direction == 1)
                rb.AddForce(Vector2.right * dashforce, ForceMode2D.Impulse);
            if (direction == -1)
                rb.AddForce(Vector2.left * dashforce, ForceMode2D.Impulse);
        }
    }

    void OnTriggerEnter2D (Collider2D col)
    {
        if (col.gameObject.tag == "EndLevel")
        {
            SceneManager.LoadScene(+2);
        }
    }
 
}
