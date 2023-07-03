using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrameLimit : MonoBehaviour
{
    private int Framerate = 60;

    void Awake()
    {
        Application.targetFrameRate = 50;

    }
}
