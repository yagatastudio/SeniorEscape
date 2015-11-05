using UnityEngine;
using System.Collections;

public class MoveCharacter : MonoBehaviour {
	protected float moveSpeed=15;
	protected float jumpHeight=20;
	public float Timer=3;

    string time;
    private float timer1=1f;
	public int doublejump = 2;
	const int DOUBLEJUMP = 2;

	// Use this for initialization
	void Start () {
        Time.timeScale = 0f;
        if (timer1>=0)
        {
            timer1 -= Time.time;
        }
        else
        {
            timer1 = -1f;
        }
	}

	protected void respawn(){
		//transform.position = new Vector2 (-24, -40);
        transform.position = new Vector2(-24, -42);
	}

	//Vérifie si le personnage rentre en collision avec un objet du groupe Bonus_Speed et si oui, augmente ça vitesse
	protected void OnTriggerEnter2D(Collider2D other) {
		if (other.gameObject.CompareTag ("Bonus_Speed")) {
			other.gameObject.SetActive (false);
			moveSpeed = 25;
		}

        if (other.gameObject.CompareTag("Jump_Spring"))
        {
            GetComponent<Rigidbody2D>().velocity = new Vector3(0, 40, 0);
        }
	}

	protected void OnCollisionEnter2D(Collision2D coll)
	{
		doublejump = DOUBLEJUMP; // remet la valeur doublejump à 2;
	}
}
