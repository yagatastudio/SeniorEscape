using UnityEngine;
using System.Collections;

public class MoveCharacter : MonoBehaviour {
	protected float moveSpeed=15;
	protected float jumpHeight=20;
	public float Timer=3;

    string time;
    private float timer1=1f;
    private bool enPause = false;
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
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            enPause = !enPause;
        }

        if (enPause==true)
        {
            Time.timeScale = 0f;
        }
        else
        {
            Time.timeScale = 1f;
        }
	}

    void OnGUI()
    {
        if (enPause)
        {
            if (GUI.Button(new Rect(Screen.width / 2 -40, Screen.height / 2-20, 80, 40), "Continuer"))
            {
                enPause = false;
            }

            if (GUI.Button(new Rect(Screen.width / 2 - 40, Screen.height / 2 + 40, 80, 40), "Quitter")) 
            {
                Application.LoadLevel("menu");
            }
        }

        for (int i = 5; i > 0; i--)
        {
            i.ToString(time);
            GUI.Label(new Rect(17, 1, Screen.width / 2, Screen.height / 2), time);
            timer1 -= Time.deltaTime;
        }
        
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
