using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

public class Pulse : MonoBehaviour
{
    public Volume postProcessVolume;

    Bloom _bloom;

    public float bloomIntensity = 1f;
    //public float pulseSpeed = 10f;

    // Start is called before the first frame update
    void Start()
    {
        postProcessVolume.profile.TryGet(out _bloom);
    }

    // Update is called once per frame
    void Update()
    {
        //_bloom.intensity.value = Mathf.PingPong(Time.time*pulseSpeed, bloomIntensity)*500f;
        _bloom.intensity.value = bloomIntensity;
    }
}
