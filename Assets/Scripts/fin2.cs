using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class fin2 : MonoBehaviour {
    public static Personnage gagnant;
    Text text1;
	// Use this for initialization
    void Start()
    {
        Debug.Log("START");
        text1 = GetComponent<Text>();
        Debug.Log(gagnant);
        if (gagnant == Personnage.FRITZ)
        {
            text1.text = "Fritz a gagné!!!";
        }
        else if (gagnant == Personnage.ROMAIN)
        {
            text1.text = "Romain a gagné!!!";
        }
        else
        {
            text1.text = "Erreur";
        }
    }
	
	// Update is called once per frame
	void Update () {
	    
	}
}

public enum Personnage {
    ROMAIN, FRITZ
}
