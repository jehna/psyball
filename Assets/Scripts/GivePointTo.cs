using UnityEngine;
using System.Collections;

public class GivePointTo : MonoBehaviour {

	public string target = "";
	
	void OnCollisionEnter () {
		PlayerPrefs.SetInt(target, PlayerPrefs.GetInt(target) + 1);
		Application.LoadLevel(0);
	}
}
