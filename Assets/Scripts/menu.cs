using UnityEngine;
using System.Collections;
using Assets.Scripts;

public class menu : MonoBehaviour {

	public void StartGame()
    {
        float fadeTime = GameObject.Find("fading").GetComponent<Fading>().BeginFade(1);
        
        Application.LoadLevel(1);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
