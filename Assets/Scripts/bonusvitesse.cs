using UnityEngine;
using System.Collections;

public class bonusvitesse : MonoBehaviour {
	public float LimitTop = 32;
	public float LimitBottom = -20;
	public float LimitLeft = -28;
	public float LimitRight = 40;

	// Use this for initialization
	void Start () {
		transform.position = new Vector3 (Random.Range (LimitRight, LimitLeft), Random.Range (LimitBottom, LimitTop), 0);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D(Collider2D other) {
		if (other.gameObject.CompareTag ("Sol")) {
			transform.position = new Vector3 (Random.Range (LimitBottom, LimitTop), Random.Range (LimitRight, LimitLeft), 0);
		}
	}
}
