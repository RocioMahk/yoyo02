using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//MANTENER DIALOGO
//

public class dialogHolder : MonoBehaviour {

	//variable del texto a escribir en el cuadro 
	public string dialogue;
	//objeto de DIALOGUEMANAGER
	private DialogueManager dMan;

	//objeto PLAYERCONTROLLER, player
	public PlayerController player;



	void Start () {
		//asignamos el objeto DIALOGUEMANAGER a dMan
		dMan = FindObjectOfType<DialogueManager> ();
		
	}


	void Update () {
	}

	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject.name == "Player") {
			dMan.ShowBox (dialogue);		
			
		} 
}
	void OnTriggerExit2D(Collider2D other)
	{
		if (other.gameObject.name == "Player") {
			dMan.HideBox ();
		}
	}
}
