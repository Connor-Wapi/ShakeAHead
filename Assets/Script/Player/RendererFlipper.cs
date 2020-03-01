using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RendererFlipper : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rigidbody2D;

    void Update()
    {
        if (rigidbody2D.velocity.x > 0)
        {
            transform.localScale = new Vector3(1,1,1);
        }
        else if (rigidbody2D.velocity.x < 0)
        {
            transform.localScale = new Vector3(-1,1,1);
        }
    }
}
