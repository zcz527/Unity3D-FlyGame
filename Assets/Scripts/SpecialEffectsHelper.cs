using UnityEngine;
using System.Collections;

public class SpecialEffectsHelper : MonoBehaviour
{

    public static SpecialEffectsHelper instance;
    public ParticleSystem smokeEffect;
    public ParticleSystem fireEffect;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    public void Explosion(Vector3 position)
    {
        instantiate(smokeEffect, position);
        instantiate(fireEffect, position);
    }

    private ParticleSystem instantiate(ParticleSystem prefab, Vector3 position)
    {
        ParticleSystem newParticleSystem = Instantiate(prefab, position, Quaternion.identity) as ParticleSystem;

        Destroy(newParticleSystem.gameObject, newParticleSystem.startLifetime);
        return newParticleSystem;
    }
}
