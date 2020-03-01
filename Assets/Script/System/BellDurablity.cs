using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BellDurablity : MonoBehaviour
{
    public static BellDurablity Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = FindObjectOfType<BellDurablity>();
            }
            return _instance;
        }
    }
    private static BellDurablity _instance;

    public int Durability => _durability;
    
    [SerializeField] private int durabilityMax = 30;
    private int _durability;

    public bool Enough()
    {
        return _durability > 0;
    }

    public void DurabilityDown()
    {
        _durability--;
    }

    public void Restore()
    {
        _durability = durabilityMax;
    }
}
