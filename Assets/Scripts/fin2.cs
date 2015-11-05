using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class fin2 : MonoBehaviour
{
    public static Personnage gagnant;

    public GUIStyle recommencer;
    public GUIStyle menu;
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

    void OnGUI()
    {
        if (GUI.Button(new Rect(Screen.width / 2 - 300, Screen.height / 2 + 80, 250, 80), "", recommencer))
        {
            Application.LoadLevel(1);
        }

        if (GUI.Button(new Rect(Screen.width / 2 + 50, Screen.height / 2 + 80, 250, 80), "", menu))
        {
            Application.LoadLevel(0);
        }
    }
}

public enum Personnage {
    ROMAIN, FRITZ
}
