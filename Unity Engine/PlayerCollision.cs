using UnityEngine;
using System.Collections;

public class PlayerCollision : MonoBehaviour {

	public GameObject hudControl;
	public AudioSource hurt;
	public AudioListener camera;
	public Transform Respawn;
	public int PlayerMaxHealth = 100;
	public int NmbrofItens = 0;
	public Camera Helicamera;
	public GameObject Helicopter;
	public GameObject Weapon;
	public GameObject Iten1;
	public GameObject Iten2;
	public GameObject Iten3;
	public GameObject Iten4;

	public int PlayerHealth;


	public void Start () {
		Weapon.SetActive (false);
		PlayerHealth = PlayerMaxHealth;
		hudControl.GetComponent<hudControl>().magazine.enabled = false;
			}

	public void OnTriggerEnter (Collider hit){
		if (hit.gameObject.tag == "Weapon") {
			Weapon.SetActive (true);
			GameObject.Destroy(hit.gameObject);
			hudControl.GetComponent<hudControl>().magazine.enabled = true;
						Weapon.GetComponent<PlayerControl>().iswpready = true;
		}

		if (hit.gameObject.tag == ("Key")){

			GameObject.Destroy(hit.gameObject);
			NmbrofItens += 1;
		}

		if (hit.gameObject.tag == "Oceano") {
			transform.position = Respawn.position;

				



			// IMPORTANTE: 
			//GameObject.FindWithTag("tag").GetComponent<Component>().Function;


		}
		
     }
	
	
	public void OnCollisionEnter (Collision hit) {

		if (hit.gameObject.tag == "BalaT") {
			PlayerHealth -= 25;
						hurt.Play();
		}

		if (hit.gameObject.tag == "Cerca") {
			PlayerHealth -= 25;
						hurt.Play();
		}


		if (hit.gameObject == Helicopter){

			gameObject.GetComponent<FirstPersonCharacter>().enabled = false;
			Helicopter.GetComponent<AeroplaneController>().enabled = true;
			Helicopter.GetComponent<AeroplaneUserControl2Axis>().enabled = true;
			Helicamera.enabled = true;
			gameObject.GetComponent<FirstPersonCharacter>().GetComponent<Camera>().enabled = false;
		}

		if (PlayerHealth <= 0){
			transform.position = Respawn.position;
			PlayerHealth = PlayerMaxHealth;
		}

				
	}
}
