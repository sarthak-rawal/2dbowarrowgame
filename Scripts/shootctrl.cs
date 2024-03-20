using UnityEngine;

public class shootctrl : MonoBehaviour
{
    public static bool canShoot = true; // Indicates if shooting is allowed
    public static bool isPlayer1Turn = true; // Tracks whose turn it is to shoot
    public bool isPlayer1;
    public GameObject arrow;
    public float launchForce;
    public Transform shotPoint;

    void Update()
    {
        Vector2 bowPosition = transform.position;
        Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector2 direction = mousePosition - bowPosition;
        transform.right = direction;

        // Check if it's the current player's turn and the mouse button is pressed
        if (Input.GetMouseButtonDown(0) && canShoot && ((isPlayer1 && isPlayer1Turn) || (!isPlayer1 && !isPlayer1Turn)))
        {
            StartCoroutine(Shoot(isPlayer1 ? "Player 1" : "Player 2"));
        }
    }

    System.Collections.IEnumerator Shoot(string playerName)
    {
        canShoot = false; // Prevent further shooting until this turn is over
       /* Debug.Log($"{playerName} is shooting.");*/

        GameObject newArrow = Instantiate(arrow, shotPoint.position, shotPoint.rotation);
        newArrow.GetComponent<Rigidbody2D>().velocity = transform.right * launchForce;

        yield return new WaitForSeconds(1); // Simulate the shooting duration

        // Toggle the turn to the other player after shooting
        isPlayer1Turn = !isPlayer1Turn;

        canShoot = true; // Allow the next player to shoot
    }
}
