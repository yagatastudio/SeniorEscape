using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class compte_a_rebour_debut : MonoBehaviour {
	// Use this for initialization
    public static bool stopped = true;
    Text compteur;
    public float compte=5;
	void Start () {
        compteur = GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
        compte -= Time.deltaTime;
        if (compte>-2)
        {
            
            if (compte<1)
            {
                compteur.text = "GO!!!";
            }
            if (compte<0)
            {
                compteur.text = "";
                stopped = false;
            }
            if (compte>1)
            {
                compteur.text = ((int)compte).ToString();
            }
        }
	}
}
