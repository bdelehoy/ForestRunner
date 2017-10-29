using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeAudio : MonoBehaviour {

    AudioSource music;

	void Start () {
        music = GetComponent<AudioSource>();
	}

    public void FadeMusic(bool fadeDirection)
    {
        StartCoroutine(FadeM(fadeDirection));
    }

	public IEnumerator FadeM(bool fadeDirection)
    {
        if (fadeDirection)
        {
            for (float i = 1; i >= 0; i -= 0.01f)
            {
                music.volume = i;
                yield return new WaitForSeconds(Time.deltaTime);
            }
        }
        else
        {
            for (float i = 1; i <= 1; i += 0.01f)
            {
                music.volume = i;
                yield return new WaitForSeconds(Time.deltaTime);
            }
        }
    }

}
