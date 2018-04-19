using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class static_CustomInput {
	static float previousAcelerationX;
	static float previousAcelerationY;
	static float previousAcelerationZ;
	static public bool ShakeInput () {
		bool _return =false;

		float _xAccelDif = Mathf.Abs(Input.acceleration.x) - Mathf.Abs (previousAcelerationX);  
		float _yAccelDif = Mathf.Abs(Input.acceleration.y) - Mathf.Abs (previousAcelerationY);  
		float _zAccelDif = Mathf.Abs(Input.acceleration.z) - Mathf.Abs (previousAcelerationZ);  

		if (Mathf.Abs (_zAccelDif)> 0.5f)
		if (Mathf.Abs (_yAccelDif)> 0.5f)
		if (Mathf.Abs (_zAccelDif)> 0.5f){
			_return = true;
		}
		previousAcelerationX = Input.acceleration.x;
		previousAcelerationY = Input.acceleration.y;
		previousAcelerationZ = Input.acceleration.z;

		return _return;
	}


}
