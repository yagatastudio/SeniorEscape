using UnityEngine;
using System.Collections;

public class moveromain : MonoBehaviour {

	public float moveSpeed;
	public float jumpHeight;

	public int doublejump = 2;
	const int DOUBLEJUMP = 2;

	private Animator anim;

	// Use this for initialization
	void Start () {
		transform.position = new Vector2 (-3, -1);
		anim = GetComponent<Animator> ();

	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown (KeyCode.UpArrow)) {
			if (doublejump > 0) 
			{
				GetComponent<Rigidbody2D> ().velocity = new Vector2 (GetComponent<Rigidbody2D> ().velocity.x, jumpHeight);
				doublejump --;
			}
		}
		if (Input.GetKey (KeyCode.RightArrow)) {
			
			GetComponent<Rigidbody2D> ().velocity = new Vector2 (moveSpeed, GetComponent<Rigidbody2D> ().velocity.y);

			transform.localScale = new Vector3 (4, 4, 4);
			anim.SetFloat ("speedromain", 2);

		} else if (Input.GetKey (KeyCode.LeftArrow)) {
			
			GetComponent<Rigidbody2D> ().velocity = new Vector2 (-moveSpeed, GetComponent<Rigidbody2D> ().velocity.y);

			transform.localScale = new Vector3 (-4, 4, 4);
			anim.SetFloat ("speedromain", 2);
		} 
		else 
		{
			anim.SetFloat ("speedromain", 0);
		}


	}

	void OnCollisionEnter2D(Collision2D coll)
	{
		doublejump = DOUBLEJUMP; // remet la valeur doublejump à 2;
	}
}
