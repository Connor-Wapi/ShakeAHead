using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class RingingSoundEffect : MonoBehaviour
{
    [FormerlySerializedAs("ring")] [SerializeField] private Bell bell;
    [SerializeField] private ParticleSystem soundParticle;
    
    void Awake()
    {
        bell.OnRinging += PlaySoundEffect;
    }

    private void PlaySoundEffect()
    {
        soundParticle.Play();
    }
}
