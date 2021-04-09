using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    private float moveSpeed = 10.0f;
    private float JumpPower = 40.0f;
    //private bool isJumping = false;
    private Rigidbody2D body;
    // Start is called before the first frame update
    void Start()
    {
        body = gameObject.GetComponent<Rigidbody2D>(); 
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        if (Input.GetKey(KeyCode.W) && body.velocity.y == 0)
            Jump();
    }
    void Move()
    {
        if (Input.GetKey(KeyCode.D))
        {
            gameObject.GetComponent<SpriteRenderer>().flipX = true;
        }
        else if(Input.GetKey(KeyCode.A))
        {
            gameObject.GetComponent<SpriteRenderer>().flipX = false;
        }
        float h = Input.GetAxis("Horizontal");
        body.velocity = new Vector3(h, body.velocity.y/moveSpeed, 0) * moveSpeed;
    }
    void Jump()
    {
        body.AddForce(Vector3.up * JumpPower*2, ForceMode2D.Impulse);
    }
}
