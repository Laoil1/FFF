using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scr_cacadetest : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}


	void OnGUI()
	{
		if (GUI.Button(new Rect(0, 10, 100, 32), "Vibrate!"))
			Handheld.Vibrate();
	}

	
	// Update is called once per frame
	void Update () {
		if(static_CustomInput.ShakeInput ()){
			print ("Shake"); 
		}
	}
}
