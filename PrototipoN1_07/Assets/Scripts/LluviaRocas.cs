﻿using UnityEngine;
using System.Collections;

public class LluviaRocas : State
{
    public State coraza;
	public State morir;
	public GameObject player;
	public GameObject jaguar;
	public GameObject prefab;
    //public float speed;

	public float vida;

	public float changeRate;
	private float timeToChange;

	private float timeToExit;
	private bool once;

	void OnEnable()
	{
		//normalColor = renderer.material.color;
		timeToExit = 0;
		timeToChange = 2;

		once = false;
	}

	void Update()
	{
		timeToExit += Time.deltaTime;

		if (!once)
		{
			for (int i = 0; i < 3; i++) {
				Vector2 position = new Vector2(Random.Range(-20, 3), 5.5f);
				Instantiate(prefab, position, Quaternion.identity);
			}
			once = true;
		}
	}
    
    public override void CheckExit()
    {
		if (vida == 0) {
			stateMachine.ChangeState (morir);
		} else if(timeToExit >= timeToChange){
			stateMachine.ChangeState (coraza);
		}

			
    }


}



