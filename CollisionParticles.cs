using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CollisionParticles : MonoBehaviour
{
    public ParticleSystem ps;

    ParticleSystem.MainModule main;

    void Start()
    {
        main = ps.main;
        ps.gameObject.SetActive(false);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        ps.gameObject.SetActive(true);
    }
}
