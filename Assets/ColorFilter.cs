using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

public class ColorFilter : MonoBehaviour
{
    public Volume postProcessVolume;

    ColorAdjustments color;
    bool onoff = false;

    // Start is called before the first frame update
    void Start()
    {
        postProcessVolume.profile.TryGet(out color);
    }

    public void ToggleFilter()
    {
        color.active = !onoff;
        onoff = !onoff;
    }
}
