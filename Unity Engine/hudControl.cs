using UnityEngine;
using System.Collections;

public class hudControl : MonoBehaviour {

	public GUIText magazine;
	private GUIText reload;
	public GameObject PlayerControl;
	public GameObject PlayerCollision;
	public GUIText Itencount;
	public GUIText Life;




	void Start (){


	}

	public void OnGUI(){
				

		magazine.text =(PlayerControl.GetComponent<PlayerControl> ().Maxmagcount.ToString() + " / "
		                + PlayerControl.GetComponent<PlayerControl> ().Currentbulletsleft.ToString());
		Itencount.text = ("Itens:   " + PlayerCollision.GetComponent<PlayerCollision> ().NmbrofItens.ToString ());
		Life.text = ("Life:  " + PlayerCollision.GetComponent<PlayerCollision> ().PlayerHealth.ToString ()); 
	}
}

	  
