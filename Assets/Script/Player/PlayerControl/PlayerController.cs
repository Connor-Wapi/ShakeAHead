using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private HorizontalMove horizontalMove;
    [SerializeField] private VerticalMove verticalMove;

    void Start()
    {
        PlayerInputHolder.Unhold();
    }
    
    void FixedUpdate()
    {
        if (!PlayerInputHolder.Holding)
        {
            horizontalMove.Handle();
            verticalMove.Handle();   
        }
    }
}
