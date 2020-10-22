using UnityEngine;
using System.Collections;

public class PauseMenu : MonoBehaviour {

    public  GameObject gameCamera;
//	public  GameObject soundControl;
//	public  GameObject musicControl;
	public  GameObject hudControl;
    public  float      BUTTON_WIDTH             = 100;
    public  float      BUTTON_HEIGHT            = 25;
    public  float      BUTTON_OFFSET_W          = 20;
    public  float      BUTTON_OFFSET_H          = 20;
    private float      BACK_WIDTH;
    private float      BACK_HEIGHT;
    private float      BACK_POSX;
    private float      BACK_POSY;
    private float      BUTTON_POSX;
    private float      NEW_BUTTON_POSY;
    private float      CONTINUE_BUTTON_POSY;
    private float      HOWTO_BUTTON_POSY;
    private float      EXIT_BUTTON_POSY;
    private bool       pause;
    private float      timer;
    private float      originalFixedDeltaTime;


    void Start () {
        originalFixedDeltaTime                  = Time.fixedDeltaTime;
        Cursor.visible                       = false;

		BACK_WIDTH           = 2 * BUTTON_OFFSET_W + BUTTON_WIDTH;
		BACK_HEIGHT          = 5 * BUTTON_OFFSET_H + 4 * BUTTON_HEIGHT;
		BACK_POSX            = Screen.width  * 0.5F - 0.5F * BUTTON_WIDTH    - BUTTON_OFFSET_W;
		BACK_POSY            = Screen.height * 0.5F - 2    * BUTTON_OFFSET_H - 1.5F * BUTTON_HEIGHT;
		BUTTON_POSX          = BACK_POSX + BUTTON_OFFSET_W;
		NEW_BUTTON_POSY      = BACK_POSY +     BUTTON_OFFSET_H;
		CONTINUE_BUTTON_POSY = BACK_POSY + 2 * BUTTON_OFFSET_H +     BUTTON_HEIGHT;
		HOWTO_BUTTON_POSY    = BACK_POSY + 3 * BUTTON_OFFSET_H + 2 * BUTTON_HEIGHT;
		EXIT_BUTTON_POSY     = BACK_POSY + 4 * BUTTON_OFFSET_H + 3 * BUTTON_HEIGHT;
    }



    public void Update() {
        if (Input.GetKeyUp(KeyCode.P)) {
            pause = !pause;

		//	soundControl.GetComponent<SoundControl>().PlaySound("menu button");

            if (pause) {
                Cursor.visible    = true;
                Time.timeScale       = 0;
                Time.fixedDeltaTime  = 0;

                // Pause the other objects

                gameCamera.GetComponent<SimpleMouseRotator>().enabled = false;
		//		musicControl.GetComponent<MusicControl>().PauseMusic();
            } else {
                Cursor.visible   = false;
                Time.timeScale      = 1;
                Time.fixedDeltaTime = originalFixedDeltaTime;

                // Unpause the other objects


                gameCamera.GetComponent<SimpleMouseRotator>().enabled = true;
		//		musicControl.GetComponent<MusicControl>().Resume();
            }
        }
    }

    public void OnGUI() {
        if (pause) {
            Rect backRect     = new Rect(BACK_POSX,    BACK_POSY,
                                         BACK_WIDTH,   BACK_HEIGHT);
            Rect newRect      = new Rect(BUTTON_POSX,  NEW_BUTTON_POSY,
                                         BUTTON_WIDTH, BUTTON_HEIGHT);
            Rect continueRect = new Rect(BUTTON_POSX,  CONTINUE_BUTTON_POSY,
                                         BUTTON_WIDTH, BUTTON_HEIGHT);
            Rect howtoRect    = new Rect(BUTTON_POSX,  HOWTO_BUTTON_POSY,
                                         BUTTON_WIDTH, BUTTON_HEIGHT);
            Rect exitRect     = new Rect(BUTTON_POSX,  EXIT_BUTTON_POSY,
                                         BUTTON_WIDTH, BUTTON_HEIGHT);

            GUI.Box(backRect, "Menu");

            if (GUI.Button(newRect, "New")) {
                Time.timeScale      = 1;
                Time.fixedDeltaTime = originalFixedDeltaTime;
				Application.LoadLevel(1);
            }

            if (GUI.Button(continueRect, "Continue")) {
		//		soundControl.GetComponent<SoundControl>().PlaySound("menu button");
				pause = false;
				Cursor.visible   = false;
				Time.timeScale      = 1;
				Time.fixedDeltaTime = originalFixedDeltaTime;
				
				// Unpause the other objects
            }

            if (GUI.Button(howtoRect, "HowTo")) {
				// Show how to Play
		//		soundControl.GetComponent<SoundControl>().PlaySound("menu button");
            }

            if (GUI.Button(exitRect, "Exit")) {
                Application.Quit();
            }
        }
    }
}
