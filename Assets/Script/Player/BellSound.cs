using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BellSound : MonoBehaviour
{
    [SerializeField] private Bell bell;
    [SerializeField] private AudioClip audioClip;
    [SerializeField] private AudioSource audioSource;
    
    void Awake()
    {
        bell.OnRinging += () => audioSource.PlayOneShot(audioClip);
    }
}
