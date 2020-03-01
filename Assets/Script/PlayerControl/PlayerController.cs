using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private HorizontalMove horizontalMove;
    [SerializeField] private VerticalMove verticalMove;
    
    void FixedUpdate()
    {
        horizontalMove.Handle();
        verticalMove.Handle();
    }
}
