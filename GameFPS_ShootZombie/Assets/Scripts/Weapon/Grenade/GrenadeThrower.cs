using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrenadeThrower : MonoBehaviour
{
    public GameObject grenadePrefab;

    private bool firelock = false;

    void Update()
    {
        if (firelock) return;

        if (Input.GetKeyDown(KeyCode.G))
        {
            firelock = true;
            ThrowGrenade();

            Invoke("ResetFireLock", 1f);
        }
    }

    void ThrowGrenade()
    {
        GameObject grenade = Instantiate(grenadePrefab, transform.position, transform.rotation);
        grenade.GetComponent<Rigidbody>().AddForce(transform.forward * 10, ForceMode.VelocityChange);
    }

    void ResetFireLock()
    {
        firelock = false;
    }

}
