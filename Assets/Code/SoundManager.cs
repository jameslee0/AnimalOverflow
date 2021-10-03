using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static AudioClip enemyHitSound, monkeyHit, walrusHit;
    static AudioSource audios;

    void Start()
    {
        enemyHitSound = Resources.Load<AudioClip>("pop");
        monkeyHit = Resources.Load<AudioClip>("Monkey");
        walrusHit = Resources.Load<AudioClip>("Boom");

        audios = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public static void PlaySound(string clip)
    {
        switch (clip)
        {
            case "1":
                audios.PlayOneShot(enemyHitSound);
                break;
            case "2":
                audios.PlayOneShot(monkeyHit);
                break;
            case "3":
                audios.PlayOneShot(walrusHit);
                break;
        }
    }
}
