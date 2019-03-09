using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animate : MonoBehaviour {
	private Animator anim;
	public GameObject player;
	private float dis;
	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		dis = Mathf.Abs (transform.position.x - player.transform.position.x);
		anim.SetFloat ("distance", dis);
		Debug.Log (dis);

	}
}
