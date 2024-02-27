using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private bool isJumping = false;
    private bool isFalling = false;
    private bool canJump = true;
    private float jumpHeight = 20.0f;
    private float jumpSpeed = 50.0f;
    private Vector2 startPosition;

    void Start()
    {
        startPosition = transform.position;
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0) && !isJumping && canJump)
        {
            isJumping = true;
            canJump = false;
        }

        if (isJumping && !isFalling)
        {
            if (transform.position.y < startPosition.y + jumpHeight)
            {
                transform.Translate(Vector2.up * jumpSpeed * Time.deltaTime);
            }
            else
            {
                isFalling = true;
            }
        }

        if (isFalling)
        {
            if (transform.position.y > startPosition.y)
            {
                transform.Translate(Vector2.down * jumpSpeed * Time.deltaTime);
            }
            else
            {
                isJumping = false;
                isFalling = false;
                canJump = true;
                transform.position = new Vector2(transform.position.x, startPosition.y);
            }
        }
    }
}
