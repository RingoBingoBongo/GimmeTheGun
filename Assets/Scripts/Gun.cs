﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public bool held;

    [Space]
    public float ShotsPerSecond;
    public bool Shooting;

    private float TimeSinceShot = 999;

    // Update is called once per frame
    void Update()
    {
        if (Shooting)
        {
            if (TimeSinceShot > (1/ShotsPerSecond))
            {
                Shoot();
                TimeSinceShot = 0;
            }
        }

        TimeSinceShot += Time.deltaTime;

        Debug.DrawRay(transform.position + transform.up * 0.3f, transform.up * 999, Color.blue);
    }

    public void Shoot()
    {
        GetComponent<AudioSource>().Play();

        RaycastHit2D hit = Physics2D.Raycast(transform.position + transform.up * 0.3f, transform.up * 100);
        if (hit.collider != null)
        {
            Debug.Log("Hit Something: " + hit.collider.gameObject.name);

            if (hit.collider.gameObject.CompareTag("Enemy"))
            {
                
            }
        }


    }
}
