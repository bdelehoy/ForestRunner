using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;

namespace UnityStandardAssets._2D
{
    public class Restarter : MonoBehaviour
    {
        private void OnTriggerEnter2D(Collider other)
        {
            if (other.tag == "Player")
            {
                SceneManager.LoadScene(2);
            }
        }
    }
}
