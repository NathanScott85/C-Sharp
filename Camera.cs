using UnityEngine;
using System.Collections;

public class Camera : MonoBehaviour {

	public float playerLocationX;
	public float cameraSpeed = 0.04f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		float camera = Input.GetAxis("Horizontal") * cameraSpeed;
		transform.Translate(new Vector2(camera, 0));
		//transform.position.x = playerLocationX;
	}
}
