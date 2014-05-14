using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {
	private Vector3 movement;

	public int movementSpeed;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		movement = transform.position;

		if (Input.GetKey(KeyCode.UpArrow)) {
			movement.y += movementSpeed * Time.deltaTime;
		} else if (Input.GetKey(KeyCode.DownArrow)) {
			movement.y -= movementSpeed * Time.deltaTime;
		}
		
		if (Input.GetKey(KeyCode.LeftArrow)) {
			movement.x -= movementSpeed * Time.deltaTime;
		} else if (Input.GetKey(KeyCode.RightArrow)) {
			movement.x += movementSpeed * Time.deltaTime;
		}

		transform.position = movement;
	}
}
