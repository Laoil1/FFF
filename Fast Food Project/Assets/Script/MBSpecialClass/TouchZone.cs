using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TouchZone : MonoBehaviour {
	 
	int TouchCounting; 
	RectTransform TransformRect;
	Canvas canevas; 

	float SquareLeft; 
	float SquareRight; 
	float SquareUp;
	float SquareDown;

	void Awake(){
		canevas = FindObjectOfType <Canvas> ();
		TransformRect = GetComponent <RectTransform> ();
		SquareDown = TransformRect.anchoredPosition.y - (TransformRect.rect.height * canevas.scaleFactor)/2;
		SquareUp = TransformRect.anchoredPosition.y + (TransformRect.rect.height * canevas.scaleFactor)/2;
		SquareLeft = TransformRect.anchoredPosition.x - (TransformRect.rect.width * canevas.scaleFactor)/2;
		SquareRight = TransformRect.anchoredPosition.x + (TransformRect.rect.width * canevas.scaleFactor)/2; 
	}

	/// <summary>
	/// Return true if the player touchs the phone/pad in the area
	/// </summary>
	public bool isInTouchZone (){
		for (int i = 0; i < TouchCounting; i++) {
			if(Input.touches[i].position.x > SquareLeft 
				&& Input.touches[i].position.x < SquareRight
				&& Input.touches[i].position.y < SquareUp  
				&& Input.touches[i].position.y > SquareDown  
			){
				return true;
			}
		} 

		return false;
	}
	/// <summary>
	/// Return true if the player touchs the phone/pad in the area and dont move.
	/// </summary>
	public bool isStationaryInTouchZone (){
		if (isInTouchZone ()){
			for (int i = 0; i < TouchCounting; i++) {
				if(Input.touches[i].phase == TouchPhase.Stationary){
					return true;
				}
			}
		}
		return false;
	}
	/// <summary>
	/// Return true if the player touchs the phone/pad in the area and move.
	/// </summary>
	public bool isMovedInTouchZone (){
		if (isInTouchZone ()){
			for (int i = 0; i < TouchCounting; i++) {
				if(Input.touches[i].phase == TouchPhase.Moved){
					return true;
				}
			}
		}
		return false;
	}


	void Update (){
		TouchCounting = Input.touchCount;  
		if(isInTouchZone ()){
			print ("Touch");
		}
	}

}
