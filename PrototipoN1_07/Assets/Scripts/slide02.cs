using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class slide02 : MonoBehaviour {


	public GameObject right;
	public GameObject left;
	public GameObject center;
	public GameObject obj1;
	public float step;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void right_click(){
		obj1.transform.Translate(step, 0, 0);
		
	}

	public void left_click(){
		obj1.transform.Translate(-step, 0, 0);

}
}
