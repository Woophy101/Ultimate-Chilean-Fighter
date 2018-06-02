using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimController : StateMachineBehaviour {

	protected Fighter fighter;
	public bool InMov;
	public float HMov;
	public float VMov;




	override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) {

		if (fighter == null) {
			fighter = animator.gameObject.GetComponent<Fighter> ();
		}

		if (InMov == true) {
			fighter.Hmov = 0;
			fighter.Vmov = 0;

		}


	}
			
	override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) {

		if (InMov == true) {

			fighter.Hmov = 0;
		}
	

	}

}
