using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchManager : MonoBehaviour {

	bool isInTouch = false;

	Vector2 touch0Positioninit;
	Vector2 touch0PositionFinal;


	void Update () {

		GetLineV (10.0f);
		GetLineH (10.0f);
	}

	public bool GetLineV (float xMargin){
		if(Input.touchCount > 0){
			if(!isInTouch){
				isInTouch = true;
				touch0Positioninit = Input.touches [0].position;
			}
			if(Input.touches[0].phase == TouchPhase.Ended){
				touch0PositionFinal = Input.touches [0].position;
				isInTouch = false;
				if (touch0PositionFinal.x > touch0Positioninit.x-xMargin
					&& touch0PositionFinal.x < touch0Positioninit.x+xMargin){
					print ("ligneV");
					return true;
				}
			}
		}	
		return false;
	}

	public bool GetLineH (float yMargin){
		if(Input.touchCount > 0){
			if(!isInTouch){
				isInTouch = true;
				touch0Positioninit = Input.touches [0].position;
			}
			if(Input.touches[0].phase == TouchPhase.Ended){
				touch0PositionFinal = Input.touches [0].position;
				isInTouch = false;
				if (touch0PositionFinal.y > touch0Positioninit.y-yMargin
					&& touch0PositionFinal.y < touch0Positioninit.y+yMargin){
					print ("ligneH");
					return true;
				}
			}
		}	
		return false;
	}


}
