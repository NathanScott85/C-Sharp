using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	public float moveSpeed;

	public float jumpHeight;
	public Transform groundCheck;
	public float groundCheckRadius;
	public LayerMask whatIsGround;
	private bool grounded;
	private bool doubleJump;
	// Use this for initialization
	void Start () {

	}

	void FixedUpdate()
	{
		grounded = Physics2D.OverlapCircle (groundCheck.position, groundCheckRadius, whatIsGround);

	}
	
	// Update is called once per frame
	void Update () {
	

		if (grounded) {
			doubleJump = false;
		}

		if(Input.GetKeyDown(KeyCode.Space) && grounded)
		{
			//GetComponent<Rigidbody2D> ().velocity = new Vector2 (GetComponent<Rigidbody2D>().velocity.x, jumpHeight);
			Jump ();

		}



		//check if not on the ground and not double jumping.
		//double jump currently works but you end up jumping through the scene

		if (Input.GetKey (KeyCode.Space) && !grounded && !doubleJump)
		{
			//GetComponent<Rigidbody2D> ().velocity = new Vector2 (GetComponent<Rigidbody2D>().velocity.x, jumpHeight);
			doubleJump = true;
			Jump ();
		}



		if(Input.GetKey(KeyCode.D))
		{
			GetComponent<Rigidbody2D> ().velocity = new Vector2 (moveSpeed, GetComponent<Rigidbody2D>().velocity.y);
		

		}
		if(Input.GetKey(KeyCode.A))
		{
			GetComponent<Rigidbody2D> ().velocity = new Vector2 (-moveSpeed, GetComponent<Rigidbody2D>().velocity.y);

		}

	
	}

	public void Jump ()
	{
		GetComponent<Rigidbody2D> ().velocity = new Vector2 (GetComponent<Rigidbody2D>().velocity.x, jumpHeight);	
	}
}
