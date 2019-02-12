using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioController : MonoBehaviour {

    public static AudioController instance;
    public bool isSoundOn;
    public AudioSource audioSource;
    public AudioClip cuttingTreeWAxe;
    public AudioClip cuttingTreeWChainsaw;
    public AudioClip GotWood;
    public float AudioNum;
    int i;
	void Awake () {
        if (instance == null)
            instance = this;
	}

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void CuttingTreeAudio(int value)
    {
        if (isSoundOn)
        {
            if (value == 0)
            {
               
                audioSource.clip = cuttingTreeWAxe;
                audioSource.Play();
                Debug.Log(i + 1);


            }
            else if (value == 1) {
              
                
                audioSource.clip = cuttingTreeWChainsaw;
                audioSource.Play();
            }
        }
        
    }

    public void GettingWoodProcessAudio()
    {
        if (isSoundOn)
        {
            audioSource.Stop();
            audioSource.PlayOneShot(GotWood);
           
        }
    }

    IEnumerator PlayAudio(AudioClip otherClip)
    {
       
        if (audioSource.isPlaying)
        {
           
            yield return new WaitForSeconds(audioSource.clip.length);
            audioSource.clip = otherClip;
            audioSource.Play();
        }
        else
        {
            audioSource.clip = otherClip;
            audioSource.Play();
        }
    }
}
