﻿using UnityEngine;

public class DisplayActivator : MonoBehaviour
{
    [SerializeField] Camera[] _cameras;

    void Start()
    {
        var displays = Display.displays;
        for (var i = 1; i < displays.Length; i++)
        {
            displays[i].Activate();
            _cameras[i-1].targetDisplay = i;
            _cameras[i-1].enabled = true;
        }
    }
}
