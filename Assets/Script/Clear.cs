using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clear : MonoBehaviour
{
    public static event Action OnClear;
    
    void Start()
    {
        OnClear?.Invoke();   
    }
}
