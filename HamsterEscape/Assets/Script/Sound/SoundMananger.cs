using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundMananger : MonoBehaviour
{
    public static SoundMananger instance;
    [SerializeField] public AudioSource audioSource, audioSourceMusic;
    [SerializeField] public AudioClip[] sound;

    private void Awake()
    {
        instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void PlaySoundAction(int num)
    {
        switch (num)
        {
            case 0:
                audioSource.clip = sound[num];
                audioSource.Play();
                audioSource.loop = true;
                break;
            case 4:
                audioSource.clip = sound[num];
                audioSource.Play();
                audioSource.loop = true;
                break;
            default:
                audioSource.clip = sound[num];
                audioSource.Play();
                audioSource.loop = false;
                break;
        }

    }
}
