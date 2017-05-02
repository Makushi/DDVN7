using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {

	public GameObject target;
	public GameObject spawnPoints;
	float timer = 0.0f;

	void Update () 
	{
		timer += Time.deltaTime;

		if (timer > 2.0f) 
		{
			timer = 0.0f;
			Vector3 spawnPoint = spawnPoints.transform.GetChild (Random.Range (0, spawnPoints.transform.childCount)).position;
			//Vector3 prefabPosition = new Vector3 (Random.Range(-5,6), Random.Range(0,6), 10);
			Instantiate (target, spawnPoint , Quaternion.identity);
		}
	}
}