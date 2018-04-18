﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LluviaFlechas : State {

	public State estaticoX3;
	public State morir;

	private Boss boss;
	public GameObject prefab;
	//public float speed;

	//public float vida;


	private float timeToChange;

	private float timeToExit;
	private bool once;

	void OnEnable()
	{
		//normalColor = renderer.material.color;
		timeToExit = 0;
		timeToChange = 2;

		boss = FindObjectOfType<Boss> ();
		once = false;
	}

	void Update()
	{
		timeToExit += Time.deltaTime;

		if (!once)
		{
			for (int i = 0; i < 7; i++) 
			{
				Vector2 position = new Vector2(Random.Range(-10, 16), 5.5f);
				Instantiate(prefab, position, Quaternion.identity);
			}
			once = true;
		}
	}

	public override void CheckExit()
	{
		if (boss.getHealth() <= 0)
		{
			stateMachine.ChangeState(morir);
		}
		else if(timeToExit >= timeToChange)
		{
			stateMachine.ChangeState (estaticoX3);
		}

	}
}