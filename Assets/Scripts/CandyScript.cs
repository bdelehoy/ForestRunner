using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CandyScript : MonoBehaviour {

	//public AudioClip munch;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
	}

	void OnTriggerEnter2D(Collider2D other){
		if (other.tag == "Player") {
			CandyManager.score++;
			//AudioSource.PlayClipAtPoint(munch, transform.position);
			//Resources.Load<AudioClip>("munch");
			//gameObject.SetActive (false);
			StartCoroutine(playAudio());
		}
			
	}

	IEnumerator playAudio() {
		GetComponent<AudioSource>().Play();
		gameObject.GetComponent<SpriteRenderer>().enabled = false;
		yield return new WaitForSeconds (gameObject.GetComponent<AudioSource> ().clip.length);
		gameObject.GetComponent<SpriteRenderer>().enabled = true;
		gameObject.SetActive (false);

	}

}
