using UnityEngine;
using System.Collections;

public class TargetControl : MonoBehaviour {
	

	public void OnCollisionEnter (Collision hit) {
	
		if (hit.gameObject.tag == "Balap") {
			GameObject.Destroy(gameObject);	
		}
	}
}
