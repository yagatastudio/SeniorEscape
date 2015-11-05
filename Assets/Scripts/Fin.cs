using UnityEngine;
using System.Collections;

public class Fin : MonoBehaviour
{

    void OnTriggerEnter2D(Collider2D other)
    {
        Cursor.visible = true;
        if (other.gameObject.CompareTag("Romain"))
        {
            fin2.gagnant = Personnage.ROMAIN;
            Debug.Log("Romain");
            Application.LoadLevel(2);
        } 

        if (other.gameObject.CompareTag("Fritz"))
        {
            fin2.gagnant = Personnage.FRITZ;
            Debug.Log("Fritz");
            Application.LoadLevel(2);
        }
    }
}
