using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sounder : MonoBehaviour
{
    public enum Sfx { Start, Next, Jump, Item, Hit }

    public AudioClip[] clips;
    AudioSource audios;
    // Start is called before the first frame update

    private void Awake()
    {
        audios = GetComponent<AudioSource>();
        PlaySound(GameManager.level > 1 ? Sfx.Next : Sfx.Start);
    }

    void PlaySound(Sfx sfx)
    {
        audios.clip = clips[(int)sfx];
        audios.Play();
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
