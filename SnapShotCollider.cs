using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;


public class SnapShotCollider : MonoBehaviour
{
    public AudioMixerSnapshot day;
    public AudioMixerSnapshot night;
    private void OnTriggerEnter(Collider other)
   
    {
        night.TransitionTo(0.5f);    
    }

    // Update is called once per frame
    
}
