using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioClick : MonoBehaviour
{

    [SerializeField] private AudioSource audioSource;
    [SerializeField] AudioClip click;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }


}
