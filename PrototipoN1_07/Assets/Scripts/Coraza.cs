using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coraza : State {
	
	public State correr;
	public Color alertColor;

	private Color normalColor;


	void Start(){
	}

	void OnEnable()
	{
		normalColor = GetComponent<Renderer>().material.color;
	}

	void Update()
	{
		Debug.Log ("entre a coraza");
		if (GetComponent<Renderer>().material.color.Equals(normalColor)) { GetComponent<Renderer>().material.color = alertColor; }
		else { GetComponent<Renderer>().material.color = normalColor; }
	}

	public override void CheckExit()
	{
		StartCoroutine (esperar1Seg ());
	}

	IEnumerator esperar1Seg()
	{
		yield return new WaitForSecondsRealtime (10);
		stateMachine.ChangeState (correr);
	}

}
