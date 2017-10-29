using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

    public PlayerController thePlayer;

    private Vector3 lastPlayerPosition;
    private float distanceToMove;

    public AudioSource music;


	// Use this for initialization
	void Start () {
        thePlayer = FindObjectOfType<PlayerController>();
        lastPlayerPosition = thePlayer.transform.position;
        music = GetComponent<AudioSource>();
    }
	
	// Update is called once per frame
	void Update () {

        if(music.volume <= 0.35f)
        {
            music.volume += 0.001f;
        }

        distanceToMove = thePlayer.transform.position.x - lastPlayerPosition.x;

        transform.position = new Vector3(transform.position.x + distanceToMove,
            transform.position.y, transform.position.z);

        lastPlayerPosition = thePlayer.transform.position;
	}
}
