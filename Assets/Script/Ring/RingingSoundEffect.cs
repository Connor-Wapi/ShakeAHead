using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RingingSoundEffect : MonoBehaviour
{
    [SerializeField] private Ring ring;
    [SerializeField] private ParticleSystem soundParticle;
    
    void Start()
    {
        ring.OnRinging += PlaySoundEffect;
    }

    private void PlaySoundEffect()
    {
        soundParticle.Play();
    }
}
