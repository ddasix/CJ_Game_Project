using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Movement_Controller : MonoBehaviour {
	public float mSpeed = 15.0f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	private void Update () {
		if (Input.GetKey (KeyCode.W)) {
			transform.position -= transform.forward * Time.deltaTime * mSpeed;
		} 
		if (Input.GetKey (KeyCode.S)) {
			transform.position += transform.forward * Time.deltaTime * mSpeed;

		}
		if (Input.GetKey (KeyCode.A)) {
			transform.position += transform.right * Time.deltaTime * mSpeed;

		}
		if (Input.GetKey (KeyCode.D)) {
			transform.position -= transform.right * Time.deltaTime * mSpeed;
		}

		if (Input.GetKey (KeyCode.Space)) {
			transform.position += transform.up * Time.deltaTime * mSpeed;
		}

	}
}
