﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quits : MonoBehaviour {

public void quits()
    {
#if UNITY_EDITOR      
        UnityEditor.EditorApplication.isPlaying = false;
#else
         Application.Quit();
#endif
    }
}
