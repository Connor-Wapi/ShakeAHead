using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class HorizontalMove : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rigidbody2D;
    [SerializeField] private float horizontalSpeed;

    public void Handle()
    {
        var currentVelocity = rigidbody2D.velocity;
        if (Left())
        {
            rigidbody2D.velocity = new Vector2(-horizontalSpeed, currentVelocity.y);
        }
        else if (Right())
        {
            rigidbody2D.velocity = new Vector2(horizontalSpeed, currentVelocity.y);
        }
        else
        {
            rigidbody2D.velocity = new Vector2(0, currentVelocity.y);
        }
    }

    private bool Left()
    {
        return Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A);
    }

    private bool Right()
    {
        return Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D);
    }
}
