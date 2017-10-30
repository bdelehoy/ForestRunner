using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CameraController : MonoBehaviour {

    public PlayerController thePlayer;

    private Vector3 lastPlayerPosition;
    private float distanceToMove;

    public FadeToBlack objectToFade;
    public FadeAudio musicToFade;


    IEnumerator loadScene(int index)
    {
        yield return StartCoroutine(objectToFade.Fade(true));
        yield return StartCoroutine(musicToFade.FadeM(true));
        SceneManager.LoadScene(2);
    }

    // Use this for initialization
    void Start () {
        thePlayer = FindObjectOfType<PlayerController>();
        lastPlayerPosition = thePlayer.transform.position;
    }
	
	// Update is called once per frame
	void Update () {

        distanceToMove = thePlayer.transform.position.x - lastPlayerPosition.x;

        transform.position = new Vector3(transform.position.x + distanceToMove,
            transform.position.y, transform.position.z);

        lastPlayerPosition = thePlayer.transform.position;

        if (LivesManager.lives == 0)
        {
                SceneManager.LoadScene(2);
        }
	}
}
