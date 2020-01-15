using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // "Public" variables
    [SerializeField]
    private float speed = 10.0f;
    [SerializeField]
    private float jumpForce = 500.0f;

    // Private variables
    private bool isGrounded = false;
    private Rigidbody2D rBody;

    // Start is called before the first frame update
    void Start()
    {
        rBody = GetComponent<Rigidbody2D>();
    }

    // Physics
    void FixedUpdate()
    {
        Vector2 movement = Vector2.zero;
        float horiz = Input.GetAxis("Horizontal");

        // Jumping code will go here!
        if(isGrounded && Input.GetAxis("Jump") > 0 && Mathf.Approximately(rBody.velocity.y, 0.0f))
        {
            rBody.AddForce(new Vector2(0.0f, jumpForce));
            isGrounded = false;
        }

        rBody.velocity = new Vector2(horiz * speed, rBody.velocity.y);

        Debug.Log("Y velocity: " + rBody.velocity.y);
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        // Check if the object the player is colliding with is tagged ground
        if(other.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
            Debug.Log("I am on the ground");
        }
    }
}
