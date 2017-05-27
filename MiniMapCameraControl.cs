using UnityEngine;
using System.Collections;

public class MiniMapCameraControl : MonoBehaviour {

	public Transform target;
    public float     height = 15;


	public void LateUpdate() {
		transform.position = target.position + new Vector3 (0, height, 0);
		transform.rotation = target.rotation;
		transform.Rotate(90, 0, 0);
	}
}
