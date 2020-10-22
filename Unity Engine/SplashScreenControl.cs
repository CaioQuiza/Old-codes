using UnityEngine;

public class SplashScreenControl : MonoBehaviour {
	public  Material logo;
	private float    timer;
	private bool     fadeOut;
	private int      sign;


	public void Start() {
		Color c      = logo.color;
		c.a          = 0;
		logo.color   = c;
		fadeOut      = true;
		sign         = 1;

	}
	
	
	public void Update() {
		if (fadeOut) {
			timer += Time.deltaTime;
			if (timer >= 0.1F) {
				timer         = 0;
				Color c       = logo.color;
				c.a          += sign * 0.1F;
				logo.color    = c;
					if (c.a >= 1) {
					fadeOut = false;
					timer   = 0;
				} else if (c.a <= 0) {
					Application.LoadLevel(1);
				}
			}
		} else {
			timer += Time.deltaTime;
			if (timer >=2) {
				timer   = 0;
				fadeOut = true;
				sign    = -1;
			}
		}
	}
}
