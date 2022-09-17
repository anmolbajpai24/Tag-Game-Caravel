using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class AudioManager : MonoBehaviour
{
    public static AudioManager instance;
    public AudioSource CrowdSound;
    private bool _isFootStepPaused = false;

    public float highVolume;
    public float lowVolume;

    private void Awake()
    {
        CrowdSound = GetComponent<AudioSource>();
        instance = this;

        

        CrowdCheer.Play();
        footSteps.Play();
        //FootStepStartAndStope(false);
    }


    [SerializeField] private AudioSource footSteps;
    [SerializeField] private AudioSource CrowdCheer;

   // [SerializeField] private AudioSource eggHit;
   // [SerializeField] private AudioSource eggHitMale;
  //  [SerializeField] private AudioSource eggHitFemale;

    [Space(20)]
    
    [SerializeField] private AudioClip footStep1;
    [SerializeField] private AudioClip footStep2;
    [SerializeField] private AudioClip footStep3;
    [SerializeField] private AudioClip footStep4;
    [SerializeField] private AudioClip footStep5;

    public void EggHitCrack()
    {
       // eggHit.Play();
    }

    public void EggHitMale()
    {
      //  eggHitMale.Play();
    }

    public void EggHitFemale()
    {
      //  eggHitFemale.Play();
    }

    public void Update()
    {
        
        
        CrowdSound.volume = 0.6f;
        if (GameManager.instance.LevelDuration == 25)
        {
            Debug.Log("10 SECONDS");
            Debug.Log(CrowdSound.volume);
            CrowdSound.volume = highVolume;
        }
    }

    // public void FootStepStartAndStope(bool inp)
    // {
    //     if (inp)
    //     {
    //         if(_isFootStepPaused == false) return;
    //         
    //         footSteps.UnPause();
    //         _isFootStepPaused = false;
    //
    //         Debug.Log($"FootStep : unPaused");
    //     }
    //     else
    //     {
    //         if(_isFootStepPaused == true) return;
    //         
    //         footSteps.Pause();
    //         _isFootStepPaused = true;
    //         
    //         Debug.Log($"FootStep : paused");
    //     }
    // }

    public void PlayFootStep()
    {
        int randomNumber = Random.Range(1, 6);
        AudioClip clipToPlay = footStep1;

        switch (randomNumber)
        {
            case 1:
                clipToPlay = footStep1;
                break;
            case 2:
                clipToPlay = footStep2;
                break;
            case 3:
                clipToPlay = footStep3;
                break;
            case 4:
                clipToPlay = footStep4;
                break;
            case 5:
                clipToPlay = footStep5;
                break;
        }

        footSteps.PlayOneShot(clipToPlay);
    }
}