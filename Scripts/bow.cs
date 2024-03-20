using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bow : MonoBehaviour
{
    public GameObject arrow;
    public float lunchforce;
    public Transform shotpoint;


    void Update()
    {
        Vector2 bowposition = transform.position;
        Vector2 mouseposition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector2 direction = mouseposition - bowposition;
        transform.right = direction;
        /* if (Input.GetMouseButtonDown(0))
         {
             Shoot();
         }

     }
     void Shoot()
     {
         GameObject newArrow = Instantiate(arrow, shotpoint.position, shotpoint.rotation);
         newArrow.GetComponent<Rigidbody2D>().velocity = transform.right * lunchforce;
     */
    }
}
