using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scr_trail : MonoBehaviour {

	Camera c;
	TrailRenderer tr;

	void Start (){
		c = Camera.main;
		tr = GetComponent <TrailRenderer> ();
	}
	// Update is called once per frame
	void Update () {
		if (Input.touchCount > 0) {
			if(tr.enabled == false){
				tr.enabled = true;
			}
			transform.position = c.ScreenToWorldPoint (new Vector3 (Input.touches [0].position.x, Input.touches [0].position.y, c.nearClipPlane));
		} else{
			//tr.enabled = false;
		}
	}
}
