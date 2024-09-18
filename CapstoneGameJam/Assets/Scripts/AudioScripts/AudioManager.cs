using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioManager instance;

    [SerializeField] private AudioSource sfxSourceObject; 


    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    public void PlaySfx(AudioClip theClip,Transform spawnTransform,float volume)
    {
        //Spawn in gameObject
        AudioSource theSource = Instantiate(sfxSourceObject,spawnTransform.position,Quaternion.identity);


        //assign theClip
        theSource.clip = theClip;


        //assign volume
        theSource.volume = volume;

        //play sound
        theSource.Play();

        //get length of clip
        float clipLength = theSource.clip.length;


        //destroy clip after playing
        Destroy(theSource.gameObject,clipLength);

    }

}
