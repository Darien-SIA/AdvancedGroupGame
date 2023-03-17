using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementScript : MonoBehaviour
{
    public Vector3 jumpForce;
    public Vector3 moveDirection;
    public bool canJump = true;
    public bool canDash = true;
    public float speed = 20.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
    }

    void Movement()
    {
        float x = Input.GetAxisRaw("Horizontal");

        moveDirection = new Vector3(x, 0);
        transform.Translate(moveDirection * Time.deltaTime * speed);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        
    }
}
