using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControl : MonoBehaviour
{
    UIM uiManager;
    bool pause;
    bool blackout = false;

    void Start()
    {
        uiManager = FindObjectOfType<UIM>();
        pause = false;
        blackout = false;
    }

    public void BlackoutActive()
    {
        blackout = !blackout;

        if (blackout)
        {
            uiManager.SetBlackoutOpacity(1);
        }
        else
        {
            uiManager.SetBlackoutOpacity(0);
        }
    }

    public void PauseActive()
    {
        pause = !pause;

        if (pause)
        {
            uiManager.SetBlackoutOpacity(0.5f);
        }
        else
        {
            uiManager.SetBlackoutOpacity(0);
        }
    }

}
