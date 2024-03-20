using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;

using UnityEngine;

public class arrow : MonoBehaviour
{
   Rigidbody2D  rb;
    bool hashit;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (hashit == false)
        {
            float angle = Mathf.Atan2(rb.velocity.y, rb.velocity.x) * Mathf.Rad2Deg;
            transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        hashit = true;
        rb.velocity = Vector2.zero;
        rb.isKinematic = true; 
    }
}
