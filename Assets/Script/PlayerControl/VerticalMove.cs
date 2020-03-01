using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VerticalMove : MonoBehaviour
{
    [SerializeField] private GroundChecker groundChecker;
    [SerializeField] private Rigidbody2D rigidbody2D;
    [SerializeField] private float jumpForce = 10f;
    
    public void Handle()
    {
        if (Jump() && groundChecker.IsGrounded)
        {
            rigidbody2D.AddForce(new Vector2(0, jumpForce));
        }

        rigidbody2D.gravityScale = rigidbody2D.velocity.y > 0 ? 1 : 1.8f;
    }

    private bool Jump()
    {
        return Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W);
    }
}