using UnityEngine;
using System.Collections;

public class ItenControl : MonoBehaviour {

	public GameObject playercollision;	
	public GameObject weaponcontrol;
	public GameObject hudControl;
	private float Itentimer = 2;



	// Use this for initialization
	void Start () {
		Itentimer += Time.deltaTime;
	}

	public void OnTriggerEnter (Collider hit){

		if (hit.gameObject.tag == "Ammo") {
				
			weaponcontrol.GetComponent<PlayerControl>().Currentbulletsleft += 30;
			GameObject.Destroy(hit.gameObject);
		}

		if (hit.gameObject.tag == "Health") {
				
							GameObject.Destroy(hit.gameObject);
			playercollision.GetComponent<PlayerCollision>().PlayerHealth += 25;
		}
						
		if (hit.gameObject.tag == "secret") {
			Itentimer -= 1;
		
		}
		if (Itentimer <= 0) {
				
			Application.LoadLevel("Ilha");
		}
}
}