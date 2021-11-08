using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.InputSystem;

public class SnapShotManager : MonoBehaviour
{
    PlayerInput player;
    public AudioMixerSnapshot day;
    public AudioMixerSnapshot night;

    // public AudioMixer CityAmbience;
    // public AudioMixerGroup DayAmbience;

    bool isNight = false;

    public float transitionTime = 2;

    // Start is called before the first frame update
    void Start()
    {
        player = GetComponent<PlayerInput>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (!isNight)
            {
                night.TransitionTo(transitionTime);
                isNight = true;
            }
        }
        else if (isNight)
        {
            day.TransitionTo(1.0f);
            isNight = false;

        }
            
    }
}
