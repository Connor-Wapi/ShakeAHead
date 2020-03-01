using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class GroundChecker : MonoBehaviour
{
    public bool IsGrounded => grounds.Any();

    private HashSet<Collider2D> grounds = new HashSet<Collider2D>();

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.layer == LayerMask.NameToLayer("Platform"))
        {
            grounds.Add(other);
        }
    }
    
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.layer == LayerMask.NameToLayer("Platform"))
        {
            grounds.Remove(other);
        }
    }
}