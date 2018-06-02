using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AI : MonoBehaviour {

	public Fighter fighter;
	public enum ACTION {punch, kick, jump, walk, idle, block}
	public ACTION action;
	public enum AISTATE {AI, test}
	public AISTATE AIState;


	void Start () {

		fighter = GetComponent<Fighter> ();
	}
	

	void Update () {

		//Reset Triggers
		TriggerReset();

		//Action Change for Testing
		if (AIState == AISTATE.test) {
			ActionScroll ();
		}
	
		// Anim Action
		switch (action) {
		case ACTION.punch:
			fighter.anim.SetTrigger ("Punch");
			break;
		case ACTION.block:
			fighter.anim.SetBool ("Block",true);
			break;
		case ACTION.jump:
			fighter.anim.SetTrigger ("Jump");
			if (fighter.cc.isGrounded) {
				fighter.Vmov = fighter.JumpSpeed;
			}
			break;
		case ACTION.kick:
			fighter.anim.SetTrigger ("Kick");
			break;
		case ACTION.walk:
			fighter.anim.SetBool ("Walk",true);
			break;
		}
		
	}


	void TriggerReset(){

		fighter.anim.ResetTrigger ("Punch");
		fighter.anim.SetBool ("Block",false);
		fighter.anim.ResetTrigger ("Jump");
		fighter.anim.ResetTrigger ("Kick");
		fighter.anim.SetBool ("Walk",false);

	}


	void ActionScroll (){
		if (Input.GetKeyDown (KeyCode.P)) {

			switch (action) {
			case ACTION.idle:
				action = ACTION.block;
				break;
			case ACTION.block:
				action = ACTION.jump;
				break;
			case ACTION.jump:
				action = ACTION.punch;
				break;
			case ACTION.punch:
				action = ACTION.kick;
				break;
			case ACTION.kick:
				action = ACTION.walk;
				break;
			case ACTION.walk:
				action = ACTION.idle;
				break;
			}
		}
	}


}

