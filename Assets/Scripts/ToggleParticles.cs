using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(ParticleSystem))]

public class ToggleParticles : MonoBehaviour
{
    public KeyCode toggleKey = KeyCode.Space;

    private ParticleSystem particle;
    public GameObject pointLight;

    bool isPlaying = true;

    private void Start()
    {
        particle = GetComponent<ParticleSystem>();
    }

    void Update()
    {
        if (Input.GetKeyDown(toggleKey))
        {
            if (isPlaying)
            {
                particle.Stop();
                pointLight.SetActive(false);
                
                isPlaying = false;
            }
            else
            {
                particle.Play();
                pointLight.SetActive(true);
                isPlaying = true;
            }
        }
    }
}
