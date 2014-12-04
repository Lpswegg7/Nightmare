using UnityEngine;
using System.Collections;

public class PlatformControllerScript : MonoBehaviour 
{
	public float moveSpeed;
	public int direction = 1;
	

	void Update()
	{

			transform.Translate (Vector2.right * direction * moveSpeed * Time.deltaTime);
			
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
		
	}
	
}

