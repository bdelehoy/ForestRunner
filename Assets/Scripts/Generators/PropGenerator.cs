using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PropGenerator: MonoBehaviour {

    public GameObject theProp;
    public Transform generationPoint;
    public float distanceBetween;

    public float distanceBetweenMin;
    public float distanceBetweenMax;

    public GameObject[] theProps;
    private int propSelector;


    public ObjectPooler[] theObjectPools;

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

            propSelector = Random.Range(0, theProps.Length);
            
            GameObject newProp = theObjectPools[propSelector].GetPooledObject();

            newProp.transform.position = transform.position;
            newProp.transform.rotation = transform.rotation;
            newProp.SetActive(true);
            
        }

    }
}