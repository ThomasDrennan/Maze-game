using System.Collections;
using UnityEngine;

public class PlayerBehaviour : MonoBehaviour {
	public float moveSpeed = 10f;
		
	void FixedUpdate () 
	{
		float moveX = Input.GetAxis ("Horizontal");
		float moveZ = Input.GetAxis ("Vertical");

		//Movement
		Vector3 movement = new Vector3(moveX, 0f, moveZ);
		GetComponent<Rigidbody> ().velocity = movement * moveSpeed * Time.deltaTime;
	}
}
