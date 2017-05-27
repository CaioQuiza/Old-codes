using UnityEngine;
using System.Collections;

public class Pausemenu : MonoBehaviour {

	private bool isPause = false;
	public GameObject MenuinGame;
	public GameObject Restartbt;
	public GameObject Mainmenubt;
	public GameObject Exitbt;
	public GameObject MusicsPlayer;
	public void Start() {

		MenuinGame.SetActive(false);
		Restartbt.SetActive (false);
		Mainmenubt.SetActive (false);
		Exitbt.SetActive (false);
	}



	public void Update () {
	if( Input.GetKeyDown(KeyCode.Escape))
	{
		
		isPause = !isPause;
		
		if(isPause){
			Time.timeScale = 0;
			MenuinGame.SetActive(true);
			Restartbt.SetActive (true);
			Mainmenubt.SetActive (true);
				Exitbt.SetActive (true);}
		else{
				Time.timeScale = 1;
				MenuinGame.SetActive(false);
				Restartbt.SetActive (false);
				Mainmenubt.SetActive (false);
				Exitbt.SetActive (false);}
	}
}
}
	