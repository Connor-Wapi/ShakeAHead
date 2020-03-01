using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BellItem : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.layer == LayerMask.NameToLayer("Player"))
        {
            BellDurablity.Instance.Restore();
            Destroy(gameObject);
        }
    }
}
