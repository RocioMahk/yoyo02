using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class detectArea : MonoBehaviour {

	public GameObject cosa;
	private Rigidbody2D rid;
	// Use this for initialization
	void Start () {
		//pico = this.gameObject; 
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject.name == "Player") {
			//Debug.Log("hola");

			cosa.gameObject.AddComponent<Rigidbody2D> ();
			//pico.gameObject.AddComponent<Rigidbody2D> ().freezeRotation = false;
		}
	}
}
