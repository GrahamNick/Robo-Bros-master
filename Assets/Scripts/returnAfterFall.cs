using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class returnAfterFall : MonoBehaviour {
	private Vector3 startpos;
	// Use this for initialization
	void Start () {
		startpos = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		if (transform.position.y <=  -2) {
			transform.position = startpos;
		}
	}
}
