using UnityEngine;
using System.Collections;

public class SecretRoomControl : MonoBehaviour {

	public Animation door;
	public GameObject doorTrigger;

	void Update () {
	

		if (gameObject.GetComponent<PlayerCollision>().NmbrofItens >= 4) {
				
			door.Play();

		}
	

		}

	public void OnCollisionEnter (Collision hit){

		if (hit.gameObject.tag == "Player"){}
		Application.LoadLevel("SecretRoom");
		}
}

