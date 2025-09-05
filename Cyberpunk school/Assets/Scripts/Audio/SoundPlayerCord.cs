using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio; 

public class SoundPlayerCord : MonoBehaviour
{

    [Header("Set by Inspector")]
    public SoundType sound; 

    public float volume;

    public AudioMixer audioMixer;

    private SoundManager soundManager;

    private void Start()
    {
        soundManager = FindObjectOfType<SoundManager>();
    }

    public void playSound()
    {
        Debug.Log("Sounding");
        soundManager.PlaySoundNorm(audioMixer, sound, volume);
    }

}
