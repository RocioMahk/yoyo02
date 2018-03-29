using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//ADMINISTRADOR DE DIALOGO
//se encarga de activar o desactivar el cuadro de texto
//segun condicion de activacion y tecleo

public class DialogueManager : MonoBehaviour {

	//variable de caja de texto
	public GameObject dBox;
	//variable de texto
	public Text dText;
	//variable para activar y desactivar el cuadro de dialogo
	public bool dialogActive;



	public void ShowBox(string dialogue)
	{
		//se activa el cuadro de texto y la variable de activacion es verdadera
		dialogActive = true;
		dBox.SetActive (true);
		//se escribe lo que se haya mandado
		dText.text = dialogue;
	}

	public void HideBox()
	{
		dBox.SetActive (false);
	}
}
