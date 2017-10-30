using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LivesManager : MonoBehaviour {

	public static int lives= 3;
	Text livesLeft;

	// Use this for initialization
	void Start () {
		livesLeft = GetComponent<Text> ();
	}

	// Update is called once per frame
	void Update () {
		livesLeft.text = string.Format ("x {3}", lives);
	}
}
