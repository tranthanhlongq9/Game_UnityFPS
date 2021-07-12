using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollideCup : MonoBehaviour
{
    public AudioSource impactFX;

    public void OnCollisionEnter(Collision collision)
    {
        if(collision.relativeVelocity.magnitude > 0.75f)
        {
            impactFX.Play();
        }
    }

   
}
