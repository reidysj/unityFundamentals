﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScreenSwitcher : MonoBehaviour
{
    
    public void SceneSwitch()
    {
        SceneManager.LoadScene(1);
    }
}
