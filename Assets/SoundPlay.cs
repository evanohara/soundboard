using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundPlay : MonoBehaviour
{
    AudioSource source;
    void Start()
    {
        source = GetComponent<AudioSource>();
    }

    public void PlayOrPause()
    {
        if (source.isPlaying)
            source.Stop();
        else
            source.Play();
    }
}
