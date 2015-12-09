using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour {
	
	public Transform tgt;
	public float speed = 0.5f;
	
	void FixedUpdate () {
		transform.position += Vector3.left * (transform.position.x - tgt.position.x) * Time.fixedDeltaTime * speed;
	}
}
