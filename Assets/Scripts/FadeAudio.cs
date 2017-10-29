using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeAudio : MonoBehaviour {

    AudioSource music;

	void Start () {
        music = GetComponent<AudioSource>();
	}

    public void FadeMusic()
    {
        StartCoroutine(FadeM());
    }

	public IEnumerator FadeM()
    {
        for (float i = 1; i >= 0; i -= 0.01f)
        {
            music.volume = i;
            yield return new WaitForSeconds(Time.deltaTime);
        }
    }

}
