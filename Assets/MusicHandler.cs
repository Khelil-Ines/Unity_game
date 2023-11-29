using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MusicHandler : MonoBehaviour
{
    AudioSource audioSource;
    Image imageAudio;
    public Sprite imageoff;
    public Sprite imageon;
    public bool musicOn = true;
    GameObject audioGame;
    public bool mainmenu = false;
    public AudioClip audioClip;
    // Start is called before the first frame update
    void Start()
    {
        audioGame = GameObject.FindGameObjectWithTag("Audio");
        if (audioGame != null) { 
        audioSource = audioGame.GetComponent<AudioSource>();
        musicOn = audioSource.isPlaying;
            if (mainmenu)
            {
                audioSource.volume = 1f;
                audioSource.clip = audioClip;
                audioSource.Play();
            }
        }
        musicOn = audioSource.isPlaying;
        imageAudio = GetComponent<Image>();

       
        if (musicOn)
        {
            imageAudio.sprite = imageon;
        }else
        {
            imageAudio.sprite = imageoff;
        }
        
    }

    public void Swap()
    {
        if(audioGame == null) { return; }
        if (musicOn)
        {
            StopMusic();
            
            
        }
        else
        {
            PlayMusic();
            }
        musicOn = !musicOn;
    }
    public void PlayMusic()
    {
        audioSource.Play();
        imageAudio.sprite = imageon;
    } 
    public void StopMusic()
    {
        audioSource.Stop();
        imageAudio.sprite = imageoff;
    }

}
