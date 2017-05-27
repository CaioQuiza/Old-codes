using UnityEngine;
using System.Collections;

public class SecretRoom : MonoBehaviour {
	public GameObject Redblock;
	public GameObject Greenblock;
	public GameObject Blueblock;
	public GameObject Cyanblock;
	public GameObject Pinkblock;
	public GameObject Yellowblock;
	public GameObject SecretIten;
	public Transform Roomrespawn;
	public bool Isreddown;
	public bool Isbluedown;
	public bool Isgreendown;
	public bool Ispinkdown;
	public bool Isyellowdown;
	public bool Iscyandown;



	void Start () {
		Isreddown = false;
		Isbluedown = false;
		Isgreendown = false;
		Ispinkdown = false;
		Isyellowdown = false;
		Iscyandown = false;
		SecretIten.GetComponent<MeshRenderer>().enabled = false;

	}
	

	public void OnTriggerEnter (Collider hit){



		if (hit.gameObject.tag == "Red"){

			Isreddown = true;
		}

		if (hit.gameObject.tag == "Blue"){
			
			Isbluedown = true;
		}

		if (hit.gameObject.tag == "Green"){
			
			Isgreendown = true;
		}

		if (hit.gameObject.tag == "secret"){

			Application.LoadLevel ("Ilha");
		}
		
	}
												

	void Update(){


		if (Isreddown == true && Isbluedown == true){

			Ispinkdown = true;
		}

		if (Isreddown == true && Isgreendown == true){

			Isyellowdown = true;

			if(Isgreendown == true && Isbluedown == true){

				Iscyandown = true;

				if (Iscyandown == true){

					GameObject.Destroy(Cyanblock);
					Isgreendown = false;
					Isbluedown = false;
				}

				if (Ispinkdown == true){
					
					GameObject.Destroy(Pinkblock);
					Isbluedown = false;
					Isreddown = false;
				}

				if (Isyellowdown == true){
					
					GameObject.Destroy(Yellowblock);
					Isreddown = false;
					Isgreendown = false;
				}

				if (Isyellowdown == true && Ispinkdown == true && Iscyandown == true){

					SecretIten.GetComponent<MeshRenderer>().enabled = true;
				}
			}
		}
	}
}
