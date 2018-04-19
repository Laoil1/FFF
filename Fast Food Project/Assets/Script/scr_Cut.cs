using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scr_Cut : MonoBehaviour {
	Animator anim;
	bool StartAnim = false;
	float timer;

	public float animationSpeed = 3;

	public  TouchZone[] touchesZones;
	int orderOfCut; 
	int passedI = -1;
	 
	[HideInInspector]
	public int isCuted;

	public int numberOfSlice;

	void Start (){
		anim = GetComponent <Animator> ();
	}

	void Update () {
		if (StartAnim){
			anim.SetInteger ("Slice",isCuted);
				timer += Time.deltaTime;
			if (timer>0.2 && Input.touchCount<=0){
					print ("Cut");
					StartAnim = false;
					isCuted ++;
				}
		}else{
			Cut ();
		}
	}

	void Cut (){
		if (Input.touchCount >0){
			for (int i = 0; i < touchesZones.Length; i++) {
				if (touchesZones [i].isInTouchZone ()){
					if (passedI != i){
						orderOfCut++;
						passedI = i;
					}
				}
			}
		}else{
			orderOfCut = 0;
			passedI = -1;
		}

		if (orderOfCut>touchesZones.Length-1){
			StartAnim = true;

		}
	}
}
