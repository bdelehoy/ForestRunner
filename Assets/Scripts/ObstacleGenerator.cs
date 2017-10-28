using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleGenerator : MonoBehaviour {

    public GameObject theObstacle;
    public Transform generationPoint;
    public float distanceBetween;

    public float distanceBetweenMin;
    public float distanceBetweenMax;

    // Use this for initialization
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (transform.position.x < generationPoint.position.x)
        {

            distanceBetween = Random.Range(distanceBetweenMin, distanceBetweenMax);

            transform.position = new Vector3(transform.position.x + distanceBetween,
                transform.position.y, transform.position.z);

            Instantiate(theObstacle, transform.position, transform.rotation);
        }

    }
}
