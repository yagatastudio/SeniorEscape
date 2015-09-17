using UnityEngine;
using System.Collections;

public class moveromain : MonoBehaviour {

	public float moveSpeed;
	public float jumpHeight;
	const int DOUBLEJUMP=2;

	private Animator anim;

	// Use this for initialization
	void Start () {
	
		anim = GetComponent<Animator> ();

	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.UpArrow)) {
			if (DOUBLEJUMP>0) {
				GetComponent<Rigidbody2D> ().velocity = new Vector2 (GetComponent<Rigidbody2D> ().velocity.x, jumpHeight);
	
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
}
