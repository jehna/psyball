#pragma strict


function Update () {
	if(Input.anyKeyDown) {
		GetComponent.<Rigidbody>().velocity += Vector3.one;
		GetComponent.<Rigidbody>().WakeUp();
		Destroy(this);
	}
}