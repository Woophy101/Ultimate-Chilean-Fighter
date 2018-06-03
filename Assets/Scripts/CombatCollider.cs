using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CombatCollider : MonoBehaviour {

	public string punchName;
	public float dmg;
	public bool atack = true;

	public Fighter owner;
	public Fighter enemy;
	public Renderer rend;

	void Start (){

		Fighter owner = transform.root.GetComponent<Fighter> ();
		Debug.Log ("Fighter GET" + owner);
		Renderer rend = GetComponent<Renderer> ();
		rend.enabled = false;	

	}

	void OnTriggerEnter (Collider col){

		Fighter enemy = col.gameObject.GetComponent<Fighter> ();


		switch (tag) {
		case "Collider.Atk":
			if (col.tag == tag) {
		
			} else {

			}
			break;
		case "Collider.Def":
			if (col.tag == tag) {
	
			} else {
	
			}
			break;
		}
	}
}

