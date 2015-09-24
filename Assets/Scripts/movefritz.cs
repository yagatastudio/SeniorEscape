using UnityEngine;
using System.Collections;

public class movefritz : MonoBehaviour {

	private float moveSpeed=15;
	private float jumpHeight=20;
	public float Timer=3;

	public int doublejump = 2;
	const int DOUBLEJUMP = 2;

	private Animator anim;

	//Se lance au démarrage du jeu
	void Start () {
		transform.position = new Vector2 (-4, -2);
		anim = GetComponent<Animator> ();

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
	
	void OnCollisionEnter2D(Collision2D coll)
	{
		doublejump = DOUBLEJUMP; // remet la valeur doublejump à 2;
	}

	//Vérifie si le personnage rentre en collision avec un objet du groupe Bonus_Speed et si oui, augmente ça vitesse
	void OnTriggerEnter2D(Collider2D other) {
		if (other.gameObject.CompareTag("Bonus_Speed")) {
			other.gameObject.SetActive(false);
			moveSpeed=25;
		}

		if (other.gameObject.CompareTag("Jump_Spring")) {
			GetComponent<Rigidbody2D>().velocity=new Vector3(0,40,0);
		}
	}
}
