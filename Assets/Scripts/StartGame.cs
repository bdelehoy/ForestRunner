using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;
using UnityEngine;

public class StartGame : MonoBehaviour {

    public FadeToBlack objectToFade;
    public FadeAudio musicToFade;

    public void LoadIndex(int index)
    {
        StartCoroutine(loadScene(index));
    }

    IEnumerator loadScene(int index)
    {
        yield return StartCoroutine(objectToFade.Fade());
        yield return StartCoroutine(musicToFade.FadeM());
        SceneManager.LoadScene(index);
    }
}
