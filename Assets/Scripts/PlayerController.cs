using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public float moveSpeed;

    public float speedMultiplier;
    public float speedIncreaseMilestone;
    private float speedMilestoneCount;

    public float jumpForce;

    private Rigidbody2D playerRB;


    public bool grounded;
    public LayerMask whatIsFloor;
    public LayerMask whatIsObstacle;

    private Collider2D playerCollider;

	// Use this for initialization
	void Start () {
        playerRB = GetComponent<Rigidbody2D>();

        playerCollider = GetComponent<Collider2D>();
	}
	
	// Update is called once per frame
	void Update () {

        grounded = Physics2D.IsTouchingLayers(playerCollider, whatIsFloor);

        if(transform.position.x > speedMilestoneCount && moveSpeed < 20)
        {
            speedMilestoneCount += speedIncreaseMilestone;

            moveSpeed = moveSpeed * speedMultiplier;
            
        }

        playerRB.velocity = new Vector2(moveSpeed, playerRB.velocity.y);

        if((Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0)) && grounded == true)
        {
            playerRB.velocity = new Vector2(playerRB.velocity.x, jumpForce);
        }

        if(Physics2D.IsTouchingLayers(playerCollider, whatIsObstacle) != true)
        {
            ScoreManager.score = (int)(((int)transform.position.x + 9) * 4);
        }
    }
}
