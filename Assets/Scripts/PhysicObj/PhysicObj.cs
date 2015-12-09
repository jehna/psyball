using UnityEngine;
using System.Collections;

public class PhysicObj : MonoBehaviour {
	
	public float force = 0.5f; // Negative or positive
	
	void Start () {
	
	}
	
	public void OnTriggerStay(Collider other) {
		if(!other.attachedRigidbody) return;
		
		other.attachedRigidbody.AddForce(transform.position - other.transform.position * force, ForceMode.Force);
	}
	
}
