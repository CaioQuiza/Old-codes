using UnityEngine;
using System.Collections;

public class BulletControl : MonoBehaviour {
	public float lifetime = 5;

	public void Start() {
		GameObject.Destroy(gameObject, lifetime);
	}


	public void OnCollisionEnter(Collision hit){
		GameObject.Destroy(gameObject);
	 }
}
	


