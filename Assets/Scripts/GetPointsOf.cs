using UnityEngine;
using System.Collections;

public class GetPointsOf : MonoBehaviour {
	
	public string target = "";
	
	void Start () {
		gameObject.GetComponent<TextMesh>().text = PlayerPrefs.GetInt(target, 0).ToString();
	}
}
