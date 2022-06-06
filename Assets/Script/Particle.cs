using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Particle : MonoBehaviour
{
    private ParticleSystem theParticleSystem;
    void Start()
    {
        theParticleSystem = GetComponent<ParticleSystem>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Angle(Vector3.down, transform.forward) <= 90f)
        {
            theParticleSystem.Play();
        }
        else
        {
            theParticleSystem.Stop();
        }
    }
}
