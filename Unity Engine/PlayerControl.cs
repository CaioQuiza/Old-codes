using UnityEngine;
using System.Collections;

public class PlayerControl : MonoBehaviour
{

		public Rigidbody bullet;
		public GameObject Magazine;
		public GameObject Weapon;
		public GameObject flash; 
		public Transform muzzle;
		public Transform muzzleflash;
		public int Maxmagcount = 30;
		public float Reloadtime;
		public float maxReloadtime = 2;
		private bool isflashing;
		private bool isfiring;
		private bool isreloading;
		private bool haveammo;
		public bool iswpready;
		private float Frequency = 0.9F;
		public AudioSource rsound;
		public AudioSource shot;
		public AudioListener audio;
		private float Timer;
		public int Maxbullets = 90;
		public int Currentbulletsleft;
	
		void Start ()
		{
				isfiring = false;
				iswpready = true;
				isreloading = false;
				isflashing = false;

	
				Reloadtime = maxReloadtime;
				Currentbulletsleft = Maxbullets;
	
		}
	
		void Update ()
		{
		//controle de disparo

				if (Input.GetMouseButtonDown(0) && isreloading == false && iswpready == true) {
			
						Rigidbody b = GameObject.Instantiate (bullet, muzzle.position, muzzle.rotation) as Rigidbody;
						GameObject a = GameObject.Instantiate (flash, muzzleflash.position, muzzleflash.rotation) as GameObject;
						b.AddForce (muzzle.forward * 5000);
						shot.Play ();
						isflashing = true;
						isfiring = true;
						Maxmagcount -= 1;
						Timer += Time.deltaTime;
		
						
						iswpready = false;
				
				if (Timer >= Frequency && iswpready == false){
			
					Timer = 0;
				iswpready = true;


		}
		}
		 
		//controle dos pentes;
				if (Maxmagcount <= 0) {
					iswpready = false;
				} else {
				
						iswpready = true;
				}

			if (Input.GetKeyDown (KeyCode.R) && Maxmagcount <= 29) {

					


						isreloading = true;
						Magazine.GetComponent<Animation>().Play ();
						rsound.Play ();
				}	   

				if (isreloading == true) {
				
						Reloadtime -= 1 * Time.deltaTime;
				}

				if (Reloadtime <= 0) {
						Maxmagcount = 30;
						Currentbulletsleft = Currentbulletsleft - 30;
						isreloading = false;
						iswpready = true;
						Reloadtime = maxReloadtime;
						
				}

				if (Currentbulletsleft <= 0 && Maxmagcount <= 0) {
				
						isfiring = false;
						iswpready = false;
						isreloading = false;
						isflashing = false;
	
			if(isflashing == true)
			{
			GameObject b = GameObject.Instantiate (flash, muzzleflash.position, muzzleflash.rotation) as GameObject;
			}
				}

		}
}

