using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class ScreenShake2D : MonoBehaviour
{

    public float shakeDuration;
    public float shakeAmount;
    float timer = 1;
    Vector2 shakeXY;

    void FixedUpdate()
    {

            if (shakeDuration > 0)
            {
                shakeXY = Random.insideUnitCircle * shakeAmount;
                shakeDuration -= Time.deltaTime * timer;

                transform.localPosition = new Vector3(shakeXY.x, shakeXY.y, -10);
            }
            else
            {
                shakeDuration = 0;
            }
    }
}
