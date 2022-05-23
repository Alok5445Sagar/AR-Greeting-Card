
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SwitchSceneScript : MonoBehaviour
{
    // Start is called before the first frame update
    public void greetingcard()
    {
       SceneManager.LoadScene("GreetingCardScene");
    }

    public void rotatecube()
    {
       SceneManager.LoadScene("RotateCubeScene");
    }

    public void exitgame()
    {
       Application.Quit();
       Debug.Log("Exit Button Pressed");
    }
}
