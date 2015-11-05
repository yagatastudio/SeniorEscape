using UnityEngine;
using System.Collections;

public class moveromain : MoveCharacter {
	private Animator anim;

	//Se lance au démarrage du jeu
	void Start () {
		anim = GetComponent<Animator> ();
		transform.localScale = new Vector3 (7,7,3);
        respawn();
	}
	
	// Update is called once per frame
	void Update () {
		//Temps pour le bonus de movespeed
		if (moveSpeed!=15) {
			Timer -= Time.deltaTime;
			if (Timer<=0) {
				moveSpeed=15;
				Timer=0;
			}
		}

		if (Input.GetKeyDown (KeyCode.UpArrow)) {
			if (doublejump > 0) 
			{
				GetComponent<Rigidbody2D> ().velocity = new Vector2 (GetComponent<Rigidbody2D> ().velocity.x, jumpHeight);
				doublejump --;
			}
		}

		if (Input.GetKey (KeyCode.RightArrow)) {
			
			GetComponent<Rigidbody2D> ().velocity = new Vector2 (moveSpeed, GetComponent<Rigidbody2D> ().velocity.y);

			transform.localScale = new Vector3 (7,7,3);
			anim.SetFloat ("speedromain", 2);
			if (Input.GetKey(KeyCode.DownArrow)) {
				if (Input.GetKeyUp(KeyCode.DownArrow)) {
					transform.localScale = new Vector2 (7f,7f);
				} else{
					transform.localScale = new Vector2 (4f,4f);
				}
			}

		} else if (Input.GetKey (KeyCode.LeftArrow)) {
			
			GetComponent<Rigidbody2D> ().velocity = new Vector2 (-moveSpeed, GetComponent<Rigidbody2D> ().velocity.y);
			transform.localScale = new Vector3 (-7,7,3);
			anim.SetFloat ("speedromain", 2);
			if (Input.GetKey (KeyCode.DownArrow)) {
				if (Input.GetKeyUp(KeyCode.DownArrow)) {
					transform.localScale = new Vector2 (7f,7f);
				} else{
					transform.localScale = new Vector2 (4f,4f);
				}
			}
		} 
		else 
		{
			anim.SetFloat ("speedromain", 0);
		}
	}
	
}
