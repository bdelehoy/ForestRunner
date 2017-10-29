using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class FadeToBlack : MonoBehaviour {

    Image black;

    void Start()
    {
        black = GetComponent<Image>();
    }

    public void FadeOut()
    {
        StartCoroutine(Fade());
    }

    public IEnumerator Fade()
    {

        for (float i = 0; i <= 1; i += 0.01f)
        {
            black.color = new Color(1, 1, 1, i);
            yield return new WaitForSeconds(Time.deltaTime);

        }
    }

}
