using UnityEngine;
using System.Collections;

public class ConstantSpeed : MonoBehaviour {
	
	public float speed;
	public float accel = 10;
	
	// Update is called once per frame
	void FixedUpdate () {
		GetComponent<Rigidbody>().velocity = GetComponent<Rigidbody>().velocity.normalized * speed;
	}
	
	void Update() {
		speed += Time.deltaTime * 0.05f * accel;
	}
}
