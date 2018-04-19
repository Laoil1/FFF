using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HideImageInGame : MonoBehaviour { 

	public bool IsActive = true; 

	void Start () { 
		if(IsActive){ 
				GetComponent <Image>().enabled = false; 
			}
		}
}


