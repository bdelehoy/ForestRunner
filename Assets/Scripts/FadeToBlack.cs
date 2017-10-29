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

    public void FadeOut(bool fadeDirection)
    {
        StartCoroutine(Fade(fadeDirection));
    }

    public IEnumerator Fade(bool fadeDirection)
    {
        if (fadeDirection)
        {

            for (float i = 0; i <= 1; i += 0.04f)
            {
                black.color = new Color(1, 1, 1, i);
                yield return new WaitForSeconds(Time.deltaTime);

            }
        }
        else
        {
            for (float i = 1; i >= 0; i -= 0.04f)
            {
                black.color = new Color(1, 1, 1, i);
                yield return new WaitForSeconds(Time.deltaTime);

            }
        }

    }

}
