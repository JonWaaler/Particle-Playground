using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {

	public Transform Player;
	public float Offset_z = 3.5f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		gameObject.transform.position = new Vector3 (0, 35, Player.position.z - 20);
	}
}
