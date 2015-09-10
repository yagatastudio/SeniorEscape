using UnityEngine;
using System.Collections;

public class Move_Player1 : MonoBehaviour {
	public float moveSpeed;
	public float jumpHight;
	// Use this for initialization
	void Start () {
	
	}
	// Update is called once per frame
	void Update () {

		if(Input.GetKeyDown(KeyCode.W))
		{
			GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x, jumpHight);
		}

		if(Input.GetKeyDown(KeyCode.D))
		{
			GetComponent<Rigidbody2D>().velocity = new Vector2(moveSpeed, GetComponent<Rigidbody2D>().velocity.y);
		}

		if(Input.GetKeyDown(KeyCode.A))
		{
			GetComponent<Rigidbody2D>().velocity = new Vector2(-moveSpeed, GetComponent<Rigidbody2D>().velocity.y);
		}
	}
}
