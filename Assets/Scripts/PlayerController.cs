using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    private float speed = 10.0f;

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

        rBody.velocity = new Vector2(horiz * speed, rBody.velocity.y);
    }
}
