using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CutManager : MonoBehaviour {

	public scr_Cut [] cutableObject;
	public bool spamAuthorized; 
	int indexOfActualCutable;
	// Use this for initialization
	void Start () {
		for (int i = 0; i < cutableObject.Length; i++) {
			cutableObject [i].enabled = false;
		}
		cutableObject [0].enabled = true;
	}
	
	// Update is called once per frame
	void Update () {
		ChangeCutable ();
	}

	void ChangeCutable (){
		if(indexOfActualCutable < cutableObject.Length-1){
/*			if(cutableObject[indexOfActualCutable].isCuted){
				if(spamAuthorized){
					indexOfActualCutable++;
				}else{
					if(Input.touchCount==0){
						indexOfActualCutable++;
					}
				}
				cutableObject [indexOfActualCutable].enabled = true;
			}*/
		}
	}
}
