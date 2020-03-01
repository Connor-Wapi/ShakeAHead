using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ring : MonoBehaviour
{
    public event Action OnRinging ;
    
    [SerializeField] private Rigidbody2D rigidbody2D;
    [SerializeField] private float ringingDelay = .5f;
    
    private float _timer;

    void Update()
    {
        _timer += Time.deltaTime;
        if (rigidbody2D.velocity.magnitude > 0.5f && _timer >= ringingDelay)
        {
            ResetTimer();
            OnRinging?.Invoke();
        }
    }

    private void ResetTimer()
    {
        _timer = 0;
    }
}
