using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowOBJ : MonoBehaviour {

	public Transform followEntity;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		gameObject.GetComponent<Rigidbody> ().MovePosition (followEntity.position);
	}
}
