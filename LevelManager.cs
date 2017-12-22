using UnityEngine;
using System.Collections;

public class LevelManager : MonoBehaviour {

	public GameObject currentCheckpoint;

	// Not currently used.
	public GameObject respawnParticle;
	public GameObject deathParticle;

	public float spawnDelay;

	private PlayerController player;
	// Use this for initialization
	void Start () {
		
		//searches through the game objects looking for the player.
		player = FindObjectOfType<PlayerController> ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void RespawnPlayer()
	{
		//gets the current player position and assigns it to the check point when passing through.
		player.transform.position = currentCheckpoint.transform.position;
		//shows a debug information to check if the respawn point is working.
		Debug.Log ("Player Respawn");
	
	}

}
