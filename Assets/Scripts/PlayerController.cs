using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerController: MonoBehaviour {

	public Fighter fighter;
	float Xversor;

	void Start () {

		fighter = GetComponent<Fighter> ();
	
	}

	void Update () {   


		//INPUT

		//Movement
		Xversor=Input.GetAxis ("Horizontal");

		fighter.Hmov = Input.GetAxis ("Horizontal")*-fighter.movSpeed;
		if (Input.GetAxis ("Horizontal") != 0) {
			fighter.anim.SetBool ("Walk", true);
			//Cambiar el sentido de la animacion con el valor de GetAxis para no colocar 2 estados de "Walk" (?)
		} else {
			fighter.anim.SetBool ("Walk", false);
		}

		//Salto

		if (Input.GetKeyDown(KeyCode.W) && fighter.cc.isGrounded){
			fighter.anim.SetTrigger ("Jump");
			fighter.Vmov = fighter.JumpSpeed;
		} else{
			fighter.anim.ResetTrigger ("Jump");
		}

		//Defensa

		if (Input.GetKey(KeyCode.S)){
			fighter.anim.SetBool ("Block", true);		
		} else {
			fighter.anim.SetBool ("Block", false);
		}

		//Ataques: adaptar para colocar en Fighter.cs
			//Combos

		if (Input.GetKeyDown(KeyCode.Q)){
			fighter.anim.SetTrigger("Punch");
		}else {
			fighter.anim.ResetTrigger("Punch");
		}

		//Patadas


		if (Input.GetKeyDown(KeyCode.E)){
			fighter.anim.SetTrigger("Kick");
		}else {
			fighter.anim.ResetTrigger("Kick");
		}


		//Taunt

		if (Input.GetKeyDown (KeyCode.T)) {
			fighter.anim.SetTrigger ("Taunt");
		} else {
			fighter.anim.ResetTrigger ("Taunt");
		}

		//Hit

		if (Input.GetKeyDown (KeyCode.Space)) {
			fighter.anim.SetTrigger ("Hit");
		} else {
			fighter.anim.ResetTrigger ("Hit");
		}

		//Fall

		if (Input.GetKeyDown (KeyCode.LeftControl)) {
			fighter.anim.SetTrigger ("Fall");
		} else {
			fighter.anim.ResetTrigger ("Fall");
		}

	
	}
}


