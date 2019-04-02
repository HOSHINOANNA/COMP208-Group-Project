using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class controlVolume : MonoBehaviour
{
    public AudioSource asound;
    public Slider sd;


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Con_volume()
    {
        asound.volume = sd.value;
    }
}
