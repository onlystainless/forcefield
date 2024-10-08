using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f; // Movement speed of the player
    public Rigidbody2D rb; // Reference to the player's Rigidbody2D

    private Vector2 movement; // Store movement direction

    void Update()
    {
        // Input for movement
        movement.x = Input.GetAxisRaw("Horizontal"); // Get horizontal movement (A/D or Left/Right arrow)
        movement.y = Input.GetAxisRaw("Vertical");   // Get vertical movement (W/S or Up/Down arrow)
    }

    void FixedUpdate()
    {
        // Move the player using Rigidbody2D
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
    }
}