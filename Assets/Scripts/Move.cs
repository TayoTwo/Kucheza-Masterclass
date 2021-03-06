using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{

    //How fast should our player move?
    public float moveSpeed;
    //Get input from the player
    public float inputX;
    //Direction the player is to move
    public Vector2 moveDirection;
    //Rigidbodies handle physics for us
    Rigidbody2D rb;

    // Start is called before the first frame update
    void Start(){

        rb = GetComponent<Rigidbody2D>();
        
    }

    // Update is called once per frame
    void Update(){

        //Recieve which direction the player is moving
        inputX = Input.GetAxis("Horizontal");

        //We combine the direction the player wants to move with the speed, rigibody.velocity.y is the player's fall speed
        moveDirection = new Vector2(moveSpeed * inputX,rb.velocity.y);

        //Set our player's velocity
        rb.velocity = moveDirection;
        
    }
}
