using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Morir : State {

	public float vida;

	void Update()
	{
		if (vida == 0) {
			Debug.Log ("falleci");
			Destroy (this.gameObject);
		}
	}
		
}
