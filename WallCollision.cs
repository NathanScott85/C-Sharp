using UnityEngine;
using System.Collections;


public class Collision : MonoBehaviour
{
	void WallCollision (Collision2D coll)
	{
		if(coll.collider == true)
		{
			coll.collider.enabled = false;
		}
	}
}

public class WallCollision : MonoBehaviour {


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}




