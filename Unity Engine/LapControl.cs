using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class LapControl : MonoBehaviour {

	public float Timer = 0;
	private float currentTimer;
	public bool Istimeractive;
	public float TimerPrevlap = 0 ;
	public float TimerBestlap = 0 ;
	public  Text  LapTimer;
	public Text LastTimer;
	public Text BestTimer;
	

	public void Start() {
	

		LastTimer.text = "Zero";
		BestTimer.text = "Zero";
		Istimeractive = true;
	}
	
	
	public void Update () {

		Timer += Time.deltaTime;
		LapTimer.text = "" + Timer;
		LastTimer.text = "" + TimerPrevlap;
		BestTimer.text = "" + TimerBestlap;
	}

	void OnTriggerEnter(Collider hit){

		if (hit.gameObject.tag == "Player") {
			print ("Colisao com o player");
			TimerPrevlap = Timer;
			Timer = 0;

		}

		if (Timer < TimerPrevlap) {
			TimerBestlap = Timer;
		}

		else {

			TimerBestlap = TimerPrevlap;
		}
	}
}

	

