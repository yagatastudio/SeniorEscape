using UnityEngine;
using System.Collections;

public class movefritz : MoveCharacter {
	private Animator anim;

	//Se lance au démarrage du jeu
	void Start () {
		anim = GetComponent<Animator> ();
		transform.localScale = new Vector3 (8,8,3);
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

		//si le joueur appuie sur s, le personnage rapetissit
		if (Input.GetKeyDown (KeyCode.W)) {
			if (doublejump > 0)
			{
				GetComponent<Rigidbody2D> ().velocity = new Vector2 (GetComponent<Rigidbody2D> ().velocity.x, jumpHeight);
				doublejump --;
			}
		}  

		if (Input.GetKey (KeyCode.D)) {
			
			GetComponent<Rigidbody2D> ().velocity = new Vector2 (moveSpeed, GetComponent<Rigidbody2D> ().velocity.y);

			transform.localScale = new Vector3 (8,8,3);
			anim.SetFloat ("speedfritz", 2);
			if (Input.GetKey (KeyCode.S)) {
				if (Input.GetKeyUp(KeyCode.S)) {
					transform.localScale=new Vector2(8,8);
				} else{
					transform.localScale=new Vector2(5,5);
				}
			}

		} else if (Input.GetKey (KeyCode.A)) {
			
			GetComponent<Rigidbody2D> ().velocity = new Vector2 (-moveSpeed, GetComponent<Rigidbody2D> ().velocity.y);

			transform.localScale = new Vector3 (-8,8,3);
			anim.SetFloat ("speedfritz", 2);
			if (Input.GetKey (KeyCode.S)) {
				if (Input.GetKeyUp(KeyCode.S)) {
					transform.localScale = new Vector2 (8,8);
				} else{
					transform.localScale = new Vector2 (5,5);
				}
			}
		} 
		else 
		{
			anim.SetFloat ("speedfritz", 0);
		}

	}
}
