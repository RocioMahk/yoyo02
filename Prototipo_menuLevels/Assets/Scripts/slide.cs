using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class slide : MonoBehaviour {

	int count = 0;
	bool check = false;
	bool check1 = false;
	bool check2 = false;

	public GameObject right;
	public GameObject left;
	public GameObject center;
	public GameObject obj1;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (check == true) {
			obj1.transform.position = Vector3.Lerp (obj1.transform.position, right.transform.position, 1f * Time.deltaTime);
		} else if (check1 == true) {
			obj1.transform.position = Vector3.Lerp (obj1.transform.position, center.transform.position, 1f * Time.deltaTime);
		} else if (check2 == true) {
			obj1.transform.position = Vector3.Lerp (obj1.transform.position, left.transform.position, 1f * Time.deltaTime);
		}
		
	}

	public void right_click(){
		count++;
		if (count == 1) {
			check = true;
			check1 = false;
			check2 = false;
		} else if(count == 0){
			check = false;
			check1 = true;
			check2 = false;
		}
		else {
			count = 1;
		}
	}

	public void left_click(){
		count--;
		if (count == 0) {
			check = false;
			check1 = true;
			check2 = false;
		} else if (count == -1){
			check = false;
			check1 = false;
			check2 = true;
		} else {
			count=-1;
		}
	}

}
