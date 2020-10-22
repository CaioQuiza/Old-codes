using UnityEngine;
using System.Collections;

public class Airplanefirecontrol : MonoBehaviour {

	public Rigidbody bullet;
	public Transform muzzle;
	public Transform target;
	public float     frequency = 2;
	private float    timer;
	public AudioSource helishot;
	public AudioListener camera;
	
	
	
	// Update is called once per frame
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
			helishot.Play();
	
			
		}
	}
	

			
}
	

