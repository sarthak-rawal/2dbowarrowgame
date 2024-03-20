using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class arrowdestory : MonoBehaviour

{


    private bool collided = false;

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Target"|| collision.gameObject.tag == "p"|| collision.gameObject.tag == "p1" || !collided)
        {
            collided = true;
            Destroy(gameObject, 5f); // Destroy the arrow object after 10 seconds
        }
    }
}



