using UnityEngine;
using System.Collections;

public class Fin : fin2
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Friz"))
        {
            Time.timeScale = 0f;
            gagnant = 0;
            Application.LoadLevel(2);
        }
        if (other.gameObject.CompareTag("Romain"))
        {
            Time.timeScale = 0f;
            gagnant = 1;
            Application.LoadLevel(2);
        }
    }
}
