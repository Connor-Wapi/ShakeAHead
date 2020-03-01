using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorSound : MonoBehaviour
{
    [SerializeField] private AudioClip audioClip;
    [SerializeField] private AudioSource audioSource;
    [SerializeField] private StageManager stageManager;
    
    void Start()
    {
        stageManager.OnLoadNext += () => audioSource.PlayOneShot(audioClip);
    }
}
