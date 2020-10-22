using UnityEngine;
using System.Collections;

public class BulletTurretControl : MonoBehaviour {


	public void Start() {
		GameObject.Destroy(gameObject, 5);
	}
	
	public void OnCollisionEnter(Collision hit){
		

		GameObject.Destroy(gameObject);

 }


}

