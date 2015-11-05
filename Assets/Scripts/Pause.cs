using UnityEngine;
using System.Collections;

public class Pause : MonoBehaviour {
    private bool enPause = false;
    public GUIStyle skin;
    public GUIStyle skin2;

	// Use this for initialization
	void Start () {
        Cursor.visible = false;
	
	}
	
	// Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
                enPause = true;
        }

        if (enPause == true)
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
            Cursor.visible = true;
            if (GUI.Button(new Rect(Screen.width / 2 - 130, Screen.height / 2 -60, 250, 70),"", skin2))
            {
                Cursor.visible = false;
                enPause = false;
            }

            if (GUI.Button(new Rect(Screen.width / 2 - 130, Screen.height / 2 + 40, 250, 70),"", skin))
            {
                enPause = false;
                Application.LoadLevel(0);
            }
        }
    }
}
