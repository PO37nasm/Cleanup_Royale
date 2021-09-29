using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VolumeControl : MonoBehaviour

{
    //private FMOD.Studio.VCA VcaControl;

    private Slider slider;

    // Start is called before the first frame update
    void Start()
    {
        //VcaControl = FMODUnity.RuntimeManager.GetVCA("vca:/Master");
        slider = GetComponent<Slider>();
    }

    public void SetVolume(float volume)
    {
        //VcaControl.setVolume(volume);
    }
}
