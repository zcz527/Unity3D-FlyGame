using UnityEngine;
using System.Collections;

public class SoundEffectsHelper : MonoBehaviour
{

    public static SoundEffectsHelper instance;

    public AudioClip explosionSound;
    public AudioClip playerShotSound;
    public AudioClip enemyShotSound;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    public void MakeExplosionSound()
    {
        MakeSound(explosionSound);
    }

    private void MakeSound(AudioClip originalClip)
    {
        AudioSource.PlayClipAtPoint(originalClip, transform.position);
    }
    public void MakePlayerShotSound()
    {
        MakeSound(explosionSound);
    }
    public void MakeEnemyShotSound()
    {
        MakeSound(explosionSound);
    }
}
