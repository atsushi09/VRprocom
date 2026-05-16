
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sky : MonoBehaviour
{
    public bool Night = false;
    public bool Sun = true;
    public bool Snow = false;
    public bool Rain = false;
    public Material[] sky;
    public ParticleSystem particleSnow;
    public ParticleSystem particleRain;

    void Update()
    {
        if (Sun == true)
        {
            RenderSettings.skybox = sky[0];
        }
        if (Snow == true)
        {

            RenderSettings.skybox = sky[1];
            ParticleSystem newParticle = Instantiate(particleSnow);
            newParticle.transform.position = this.transform.position;
            newParticle.Play();
        }
        else if (Rain == true)
        {

            RenderSettings.skybox = sky[1];
            ParticleSystem newParticle = Instantiate(particleRain);
            newParticle.transform.position = this.transform.position;
            newParticle.Play();
        }
    }
}