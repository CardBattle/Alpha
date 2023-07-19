using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SFXVFX : MonoBehaviour
{
    public Action play;

    public void PlaySFXVFX() 
    {
        play();
        play = null;
    }

}
