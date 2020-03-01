using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class PlayerLifeTime : MonoBehaviour
{
    public static float LifeTime { get; private set; }
    
    [SerializeField] private float time;
    [SerializeField] private Bell bell;
    
    private float _timeLeft;

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
        if (_timeLeft < 0)
        {
            Debug.Log("End of lifetime");
        }
    }
}
