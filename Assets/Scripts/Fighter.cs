using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fighter : MonoBehaviour {

	public enum STATE {player,AI}
	public STATE State;

	public float MaxHealth;
	public float Health;
	public string CharID;
	public float JumpSpeed = 3;
	public float movSpeed = 1.3f;

	public Animator anim;
	public CharacterController cc;
	public float Hmov;
	public float Vmov;

	//Animaciones
	public bool walk;
	public bool def;
	public bool punch;
	public bool kick;
	public bool combo;
	public bool jump;
	public bool hit;
	public bool taunt;

	//Colliders
	public Collider[] AtkCollider;
	public Collider[] DefCollider;

	void Start () {

		anim = GetComponent<Animator> ();
		cc = GetComponent<CharacterController> ();

		if (State == STATE.player) {
			PlayerController pc = gameObject.AddComponent (typeof(PlayerController)) as PlayerController;
		}

	} 

	void Update () {

		//PHYSICS
			//Gravity
		if (cc.isGrounded == false) {
				Vmov += Physics.gravity.y * Time.deltaTime;
		}
			//Output Movement
		Vector3 speed = new Vector3 (Hmov, Vmov, 0);
		cc.Move (speed * Time.deltaTime);
	} // General Movement

	void OnTriggerEnter (Collider col){

		Collider [] cols = Physics.OverlapBox(col.bounds.center,col.bounds.extents,col.transform.rotation, LayerMask.GetMask("Hitbox"));
		foreach (Collider c in cols) {
			if (c.transform.root == transform.root)
				continue;

			float dmg = 0;
			switch (c.name) {
			case "Collider.Head":
				dmg = 50;
				break;
			case "Collider.Chest":
				dmg = 25;
				break;
			case "Collider.Hip":
				dmg = 10;
				break;
			default:
				Debug.Log ("Unable to identify BodyPart");
				break;
			}



			Debug.Log (name + " hitted " + c.name + " of " + c.transform.root.name + " for " + dmg);
				
			}
	} // Coll. Behaviour (DMG, DEF, BlOCK)
}
