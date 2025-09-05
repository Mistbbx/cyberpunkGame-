using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class PlaySoundEnter : StateMachineBehaviour
{

    [SerializeField] private SoundType sound;
    [SerializeField, Range(0, 1)] private float volume = 1;
    [SerializeField] private AudioMixer audioMixer;

    public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        FindObjectOfType<SoundManager>().PlaySoundNorm(audioMixer, sound, volume);
    }
}
