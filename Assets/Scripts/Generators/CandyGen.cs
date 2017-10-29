using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CandyGen : MonoBehaviour {

	public GameObject theObstacle;
	public Transform generationPoint;
	public float distanceBetween;


	public float distanceBetweenMin;
	public float distanceBetweenMax;

	public ObjectPooler theObjectPool;

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

		//	Debug.Log = "position: " + ObstacleGenerator.generationPoint.position.x; 

			//if ((theObstacle.transform.position.x - 2)> transform.position.x && ((theObstacle.transform.position.x + 2)<transform.position.x))
			//{
				transform.position = new Vector3(transform.position.x + distanceBetween,
				transform.position.y, transform.position.z);

			GameObject newPlatform = theObjectPool.GetPooledObject();

			newPlatform.transform.position = transform.position;
			newPlatform.transform.rotation = transform.rotation;
			newPlatform.SetActive(true);

			//}
		}

	}
}
