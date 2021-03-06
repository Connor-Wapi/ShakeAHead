﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class PlayerLifeTime : MonoBehaviour
{
    public static event Action OnPlayerDead;
    public static float LifeTime { get; private set; }
    
    [SerializeField] private float time;
    [SerializeField] private Bell bell;
    
    private float _timeLeft;
    private bool _dead;
    
    void Awake()
    {
        bell.OnRinging += () => _timeLeft = time;
    }
    
    void Start()
    {
        _timeLeft = time;
        LifeTime = _timeLeft;
    }
    
    void Update()
    {
        _timeLeft -= Time.deltaTime;
        LifeTime = _timeLeft;
        if (_timeLeft < 0 && !_dead)
        {
            _dead = true;
            OnPlayerDead?.Invoke();
        }
    }
}
