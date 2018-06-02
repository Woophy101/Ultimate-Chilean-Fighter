using UnityEngine;
using System.Collections.Generic;
using UnityEngine.UI;

public class UIControl : MonoBehaviour {

	public Fighter player1;
	public Fighter player2;

	public Text lText;
	public Text rText;
	public Image lLife;
	public Image rLiife;



	void Start () {

		lText.text = player1.CharID;
		rText.text = player2.CharID;
	}
	
	// Update is called once per frame
	void Update () {


		
	}
}
