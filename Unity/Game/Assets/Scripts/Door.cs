using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    public void Collision2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player1")
        {
            Destroy(gameObject);
        }
    }
}
