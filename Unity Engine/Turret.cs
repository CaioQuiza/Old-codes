using UnityEngine;
using System.Collections;

public class Turret : MonoBehaviour {
	public Rigidbody bullet;
	public Transform muzzle;
	public Transform target;
	public float     frequency = 1;
	private float    timer;
	public GameObject BulletPlayer;
	public int Health = 30;
	public AudioSource Turretshot;
	public AudioListener camera;


	
	// Update is called once per frame
	void Update () {
			 transform.LookAt(target.position);

		timer += Time.deltaTime;
		if (timer >= frequency) {
			timer = 0;
			Rigidbody b =
				
				GameObject.Instantiate(bullet,
				                       muzzle.position,
				                       muzzle.rotation) as Rigidbody;
			b.AddForce (muzzle.forward * 1500);
			b.transform.Rotate(90, 0, 90);
			Turretshot.Play();

		}
	}

	public void OnCollisionEnter (Collision hit) {

		if (hit.gameObject.tag == ("Balap")) {
						Health -= 10;
						print("10 de dano");
				}
		if (Health <= 0) {
				
			GameObject.Destroy(gameObject);
			

		}
}
}
