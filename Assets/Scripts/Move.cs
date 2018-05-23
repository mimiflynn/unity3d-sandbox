using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Debug.Log("Hello World from " + this.name);
	}

	// Update is called once per frame
	void Update () {
		if (Input.GetKey("a")) {
			Debug.Log("A is happening");

		}
	}
}
