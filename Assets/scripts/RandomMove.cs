using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomMove : MonoBehaviour {
	public Transform StartPoint;
	System.Random rand = new System.Random();

	void Start () {
		
	}

	void Update () {

		if (Vector3.Distance (transform.position, StartPoint.position) <= 5) {
			transform.position = new Vector3 (rand.Next (30)-10, 1, rand.Next (10)-10);
		}
	}
}
