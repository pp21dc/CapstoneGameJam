using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class MixerManager : MonoBehaviour
{
    [SerializeField] private AudioMixer theMixer;

  public void SetSfxVolume(float value)
    {
        theMixer.SetFloat("sfxVol", value);

    }

    public void SetMusicVolume(float value)
    {
        theMixer.SetFloat("musicVol", value);

    }

}
