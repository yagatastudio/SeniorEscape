using UnityEngine;
using System.Collections;

public class menu : MonoBehaviour {

	public void StartGame()
    {
        Application.LoadLevel(1);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
