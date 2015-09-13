using UnityEngine;
using System.Collections;

public class movefritz : MonoBehaviour {

	public float moveSpeed;
	public float jumpHeight;



	private Animator anim;

	// Use this for initialization
	void Start () {
	
		anim = GetComponent<Animator> ();

	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKey (KeyCode.W)) {

			GetComponent<Rigidbody2D> ().velocity = new Vector2 (GetComponent<Rigidbody2D> ().velocity.x, jumpHeight);
		} 

		if (Input.GetKey (KeyCode.D)) {
			
			GetComponent<Rigidbody2D> ().velocity = new Vector2 (moveSpeed, GetComponent<Rigidbody2D> ().velocity.y);

			transform.localScale = new Vector3 (5, 5, 5);
			anim.SetFloat ("speedfritz", 2);

		} else if (Input.GetKey (KeyCode.A)) {
			
			GetComponent<Rigidbody2D> ().velocity = new Vector2 (-moveSpeed, GetComponent<Rigidbody2D> ().velocity.y);

			transform.localScale = new Vector3 (-5, 5, 5);
			anim.SetFloat ("speedfritz", 2);
		} 

		else 
		{
			anim.SetFloat ("speedfritz", 0);
		}


	}
}
