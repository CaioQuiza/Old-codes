using UnityEngine;
using System.Collections;

public class Airplaneshoot : MonoBehaviour {

	public Rigidbody bullet;
	public Transform muzzle;
	public Transform target;
	public float     frequency = 5;
	private float    timer;
	public AudioSource planeshot;
	public AudioListener camera;
	
	

	void Update () {
			
		muzzle.transform.LookAt(target.position);
		timer += Time.deltaTime;
		if (timer >= frequency) {
			timer = 0;
			Rigidbody b =
				
				GameObject.Instantiate(bullet,
				                       muzzle.position,
				                       muzzle.rotation) as Rigidbody;
			b.AddForce (muzzle.forward * 500000);
			planeshot.Play();
			
			
		}
	}
	
	
	
}


