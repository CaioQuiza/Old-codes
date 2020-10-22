using UnityEngine;
using System.Collections;

public class LandmineControl : MonoBehaviour {
	public AudioSource Explosion;
	public AudioListener Camera;
	public GameObject Player;
	public Transform explosionLocation;
	public GameObject explosionPrefab;
	
	public void OnTriggerEnter (Collider hit) {

		if (hit.gameObject.tag == "Player") {
				
			//GameObject a = GameObject.Instantiate (explosionPrefab, explosionLocation, 
			//                        Quaternion.LookRotation(hit.rigidbody))as GameObject;
			gameObject.GetComponent<PlayerCollision>().PlayerHealth -= 25;
			Explosion.Play ();
			GameObject.Destroy(gameObject);
		}
	}
}
