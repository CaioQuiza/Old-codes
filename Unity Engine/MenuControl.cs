using UnityEngine;
using System.Collections;

public class MenuControl : MonoBehaviour {

	public Animation Slide;
	public GameObject Entertext;
	public bool Showingmouse;
	public GameObject Tutorial;

	void Start (){

	
		Cursor.lockState = CursorLockMode.Locked;
		Cursor.visible = true;
		Showingmouse = false;

	}
	
	void Update () {
	 
		if (Input.GetKey(KeyCode.Return)){

			Entertext.SetActive(false);
			Slide.Play();
		
			Showingmouse = true;
		}
		if (Showingmouse == true){

			Cursor.lockState = CursorLockMode.None;
			Cursor.visible = true;
		
		}
		}
}

