using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Morir : State {


	void Update()
	{
		Debug.Log ("falleci");
		Destroy (this.gameObject);

	}
		
}
