﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Knockback : MonoBehaviour {

    private void OnCollisionEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            GetComponent<AudioSource>().Play();
        }
    }
}
