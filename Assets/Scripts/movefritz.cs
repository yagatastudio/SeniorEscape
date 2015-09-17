using UnityEngine;
using System.Collections;

public class movefritz : MonoBehaviour {

	private float moveSpeed=10;
	private float jumpHeight=15;
	/*private float time=Time.fixedTime;*/

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

		if (Input.GetKeyDown (KeyCode.W)) {
			if (doublejump > 0)
			{
				GetComponent<Rigidbody2D> ().velocity = new Vector2 (GetComponent<Rigidbody2D> ().velocity.x, jumpHeight);
				doublejump --;
			}
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
	void OnCollisionEnter2D(Collision2D coll)
	{
		doublejump = DOUBLEJUMP; // remet la valeur doublejump à 2;
	}

	void OnTriggerEnter2D(Collider2D other) {
		if (other.gameObject.CompareTag("Bonus_Speed")) {
			other.gameObject.SetActive(false);
			moveSpeed=20;
			/*time=3;
			if (time==30) {
				moveSpeed=10;
			}*/
		}
	}
}
