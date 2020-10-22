using UnityEngine;
using System.Collections;

public class MiniMapHUDControl : MonoBehaviour {

	public RenderTexture miniMapTexture;
	public Material      miniMapMaterial;
    public float         MINI_MAP_WIDTH  = 128;
    public float         MINI_MAP_HEIGHT = 128;
    public float         MINI_MAP_OFFSET = 10;


	public void OnGUI() {
		if (Event.current.type == EventType.Repaint) {
			Graphics.DrawTexture(new Rect (Screen.width - MINI_MAP_WIDTH - MINI_MAP_OFFSET, 0, MINI_MAP_WIDTH, MINI_MAP_HEIGHT), miniMapTexture, miniMapMaterial);
		}
	}

}
