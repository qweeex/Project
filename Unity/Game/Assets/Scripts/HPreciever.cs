using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HPreciever : MonoBehaviour
{
    public float HP = 50;
    public Rigidbody2D shurammo;
    public Transform Point;

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Ammo")
            HP -= 50;
        if (collision.gameObject.tag == "Sword")
        {
            HP -= 10;
        }
        if (HP <= 0)
        {
            Destroy(gameObject);
            var ammoInstance = GameObject.Instantiate(shurammo.gameObject);
            ammoInstance.transform.position = Point.position;
        }
    }
}


