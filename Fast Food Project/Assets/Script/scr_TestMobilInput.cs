using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scr_TestMobilInput : MonoBehaviour {

	Text Size;

	// Use this for initialization
	void Start () { 
		Size = GetComponent <Text> ();
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.touchCount>0){
			Touch myTouch = Input.GetTouch (0);
			string myToutchPosition = myTouch.position.ToString ();
			Size.text = myToutchPosition;
		}
	}
}
