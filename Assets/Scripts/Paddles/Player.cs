using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	public float speed = 0.5f;
	
	void FixedUpdate () {
		transform.position += Vector3.left * (transform.position.x - Camera.main.ScreenToWorldPoint(Input.mousePosition).x) * Time.deltaTime * speed;
	}
}
