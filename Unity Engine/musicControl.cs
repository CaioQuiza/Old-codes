using UnityEngine;
using System.Collections;

public class musicControl : MonoBehaviour {

	public AudioSource music;
	public AudioListener camera;

	// Use this for initialization
	void Start () {

		music.Play ();
	
	}
	void Update () {

		if (music.isPlaying == false) {
				
			music.Play();
		}

		}

}
