using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
 
    public float jumpStrength;
    public float jumpInput;
    float groundCheckDis = 0.6f;
    public bool hasLanded;
    public bool isJumping;
    Rigidbody2D rb;

    // Start is called before the first frame update
    void Start(){

        rb = GetComponent<Rigidbody2D>();
        
    }

    // Update is called once per frame
    void Update(){

        jumpInput = Input.GetAxis("Jump");

        if(isGrounded() && hasLanded && !isJumping && jumpInput > 0.1f){

            rb.AddForce(Vector2.up * jumpStrength,ForceMode2D.Impulse);
            hasLanded = false;
            isJumping = true;

        }

        
    }

    bool isGrounded(){

        Vector2 origin = transform.position;
        RaycastHit2D hit = Physics2D.Raycast(origin,Vector2.down,groundCheckDis);

        if(hit.collider != null){

            // Debug.Log("Grounded");
            isJumping = false;
            hasLanded = true;
            return true;

        } else {

            // Debug.Log("Not Grounded");
            return false;

        }

    }
}
