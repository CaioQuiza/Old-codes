using UnityEngine;
using System.Collections;

public class WeaponControlRaycast : MonoBehaviour {

	public Transform muzzle;
	public GameObject sparks;
	public float frequency = 0.5F;
	private float timer;
	
	void Update () {
		if (Input.GetMouseButton(0)){
			timer += Time.deltaTime;
		}
		if (timer >= frequency){

			timer = 0;
			RaycastHit hit;

			if(Physics.Raycast(muzzle.position, muzzle.forward, out hit, 1000)){

				GameObject sp = GameObject.Instantiate(sparks, hit.point, Quaternion.LookRotation(hit.normal)) as GameObject;
			}
		}

	}
	
}

