using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour

{
    public Transform FireShootPoint;
    public Rigidbody2D fireball;
    public float AmmoForce;
    public int a = 0;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Drop")
        {
            a = 1;
        }
        if (collision.gameObject.tag == "Key")
        {
            gameObject.tag = "Player1";
        }
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse2) && a == 1)
        {
            var mousePosition = Input.mousePosition;
            var worldPosition = Camera.main.ScreenToWorldPoint(mousePosition);

            var vectorFromBarrelToMouse = worldPosition - FireShootPoint.position;
            Debug.DrawLine(FireShootPoint.position, worldPosition, Color.red);

            var ammoInstance = GameObject.Instantiate(fireball.gameObject);
            ammoInstance.transform.position = FireShootPoint.position;

            var fireRigidBody = ammoInstance.GetComponent<Rigidbody2D>();

            fireRigidBody.velocity = vectorFromBarrelToMouse.normalized * AmmoForce;

            Destroy(ammoInstance, 3f);
        }
    }
}

