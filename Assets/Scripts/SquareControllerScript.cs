using UnityEngine;
using System.Collections;

public class SquareControllerScript : MonoBehaviour 
{
	public float moveSpeed;
	public int direction = 1;

	bool grounded = true;
	public Transform groundCheck;
	float groundRadius = 0.2f;
	public LayerMask whatIsGround;

	public float jumpForce = 700f;
	

	void FixedUpdate()
	{
		grounded = Physics2D.OverlapCircle (groundCheck.position, groundRadius, whatIsGround);

	}

	void Update()
	{
		if (Input.GetKeyDown(KeyCode.Escape))
		{
				Application.Quit(); 
		}

		if (grounded && Input.GetMouseButtonDown(0))
		//if (grounded && Input.GetKeyDown (KeyCode.Space)) 
		{
			rigidbody2D.AddForce(new Vector2(0,jumpForce));
		}
		else 
		{
			transform.Translate (Vector2.right * direction * moveSpeed * Time.deltaTime);
			//rigidbody2D.velocity = new Vector2(direction * moveSpeed*Time.deltaTime,rigidbody2D.velocity.y);
		}
	}

	void OnCollisionEnter2D(Collision2D coll) 
	{
		if (coll.gameObject.tag == "Right Wall") 
		{
			direction = -1;
		}

		else if (coll.gameObject.tag == "LeftWall")
		{
			direction = 1;

		}

		if (coll.gameObject.tag == "Goal1") 
		{
			Application.LoadLevel("Level2");
				
		}

		if (coll.gameObject.tag == "Goal2") 
		{
			Application.LoadLevel("Level3");
			
		}

		if (coll.gameObject.tag == "Goal3") 
		{
			Application.LoadLevel("Level4");
			
		}

		if (coll.gameObject.tag == "Goal4") 
		{
			Application.LoadLevel("Level5");
			
		}

		if (coll.gameObject.tag == "Goal5") 
		{
			Application.LoadLevel("End");
			
		}

	}

}

