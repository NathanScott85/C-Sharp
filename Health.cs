using UnityEngine;
using System.Collections;

public class Health : MonoBehaviour {

	// Assigns the player health.
	public float health = 100f;
	//Player reset not currently used.
	public float resetAfterDeath = 5f;

	// references the player controller
	private PlayerController playerController;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
