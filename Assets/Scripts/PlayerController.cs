using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public float moveSpeed;
    public float jumpForce;

    private Rigidbody2D playerRB;


    public bool grounded;
    public LayerMask whatIsFloor;

    private Collider2D playerCollider;

	// Use this for initialization
	void Start () {
        playerRB = GetComponent<Rigidbody2D>();

        playerCollider = GetComponent<Collider2D>();
	}
	
	// Update is called once per frame
	void Update () {

        grounded = Physics2D.IsTouchingLayers(playerCollider, whatIsFloor);

        playerRB.velocity = new Vector2(moveSpeed, playerRB.velocity.y);

        if((Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0)) && grounded == true)
        {
            playerRB.velocity = new Vector2(playerRB.velocity.x, jumpForce);
        }
	}
}
