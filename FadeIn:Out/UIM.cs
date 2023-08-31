using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIM : MonoBehaviour
{
    [SerializeField]
    Image blackoutImage;
    [SerializeField]
    float blackoutStep;
    float blackoutOpacity;

    void Start()
    {
        blackoutOpacity = 0;
    }

    void FixedUpdate()
    {
        Blackout();
    }

    void Blackout()
    {
        float currentOpacity = blackoutImage.color.a;

        if (currentOpacity < blackoutOpacity)
        {
            blackoutImage.color = new Color(blackoutImage.color.r, blackoutImage.color.g, blackoutImage.color.b, blackoutImage.color.a + blackoutStep);
            if (blackoutImage.color.a > blackoutOpacity)
            {
                blackoutImage.color = new Color(blackoutImage.color.r, blackoutImage.color.g, blackoutImage.color.b, blackoutOpacity);
            }
        }
        else if (currentOpacity > blackoutOpacity)
        {
            blackoutImage.color = new Color(blackoutImage.color.r, blackoutImage.color.g, blackoutImage.color.b, blackoutImage.color.a + blackoutStep);
            if (blackoutImage.color.a < blackoutOpacity)
            {
                blackoutImage.color = new Color(blackoutImage.color.r, blackoutImage.color.g, blackoutImage.color.b, blackoutOpacity);
            }
        }
    }

    public void SetBlackoutOpacity(float o)
    {
        blackoutOpacity = o;
    }

}
