using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

	/*
	 * You are try to traverse the platform by creating
	 * explosions behind the player to move him. If you
	 * go to fast or dont care fully place the explosion
	 * the player can fall of the course.
	 * 
	 * The explosion force is determined by how long player
	 * presses hold down on screen for. You can only press
	 * on x and y axis, No forwards or backwards.
	*/

	public Transform MyCamera;
	public float Speed = 1;

	public Transform VisualExpIndicator;
	public Transform Transform_playerSpawnPT;

	private float explosionForce = 400;
	private Vector3 explosionPosition;
	private float explosionRadius = 50;

	private bool startTimer_MouseDown = false;
	private float t_mouseDown = 0;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (Input.GetMouseButtonDown(0)) 
		{
			t_mouseDown = 0;
			startTimer_MouseDown = true;
		}

		float x = Input.mousePosition.x;
		print (x);
		x *= 1.4f;
		x -= (1.4f * 1080.0f)/2.0f;
		x /= 100.0f;
		VisualExpIndicator.position = new Vector3 (x, 1, gameObject.transform.position.z - 3.0f);

		if (Input.GetMouseButtonUp (0)) 
		{
			startTimer_MouseDown = false;

			Debug.Log (x);
			gameObject.GetComponent<Rigidbody> ().AddExplosionForce (t_mouseDown*10.0f, new Vector3(x, 1, gameObject.transform.position.z - 3.0f), explosionRadius);
		}

		if (startTimer_MouseDown) {
			t_mouseDown += Time.deltaTime*Speed;

		}

		if (Input.GetKeyDown (KeyCode.Space)) {

			gameObject.GetComponent<Rigidbody> ().AddForce (0, 300, 0);
		}


		if (gameObject.transform.position.y < -5) {
			// Reset gameobject
			gameObject.transform.position = Transform_playerSpawnPT.position;

		}
	}
}
