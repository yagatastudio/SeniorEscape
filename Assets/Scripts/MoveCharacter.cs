using UnityEngine;
using System.Collections;

public class MoveCharacter : MonoBehaviour {
	protected float moveSpeed=15;
	protected float jumpHeight=20;
	public float Timer=3;
	
	public int doublejump = 2;
	const int DOUBLEJUMP = 2;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

	}

	protected void respawn(){
		transform.position = new Vector2 (-24, -40);
	}

	//Vérifie si le personnage rentre en collision avec un objet du groupe Bonus_Speed et si oui, augmente ça vitesse
	protected void OnTriggerEnter2D(Collider2D other) {
		if (other.gameObject.CompareTag ("Bonus_Speed")) {
			other.gameObject.SetActive (false);
			moveSpeed = 25;
		}
		
		if (other.gameObject.CompareTag ("Jump_Spring")) {
			GetComponent<Rigidbody2D> ().velocity = new Vector3 (0, 40, 0);
		}
	}

	protected void OnCollisionEnter2D(Collision2D coll)
	{
		doublejump = DOUBLEJUMP; // remet la valeur doublejump à 2;
	}
}
