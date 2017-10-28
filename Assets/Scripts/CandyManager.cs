using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CandyManager : MonoBehaviour {

	public static int score= 0;
	Text scoreThing;
	// Use this for initialization
	void Start () {
		scoreThing = GetComponent<Text> ();

	}

	// Update is called once per frame
	void Update () {
		scoreThing.text = string.Format ("Candy: {0}", score);
	}
}
