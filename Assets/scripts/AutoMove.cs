using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AutoMove : MonoBehaviour {

	public Transform EndPoint;

	void Start () {
	}

	void Update () {

		NavMeshAgent agent = GetComponent<NavMeshAgent>();
		agent.destination = EndPoint.position;
	}
}
