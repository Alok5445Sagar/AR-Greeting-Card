
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackAndClose : MonoBehaviour
{
  public void backbtn()
  {
     SceneManager.LoadScene("MenuScene");
  }

  public void exitbtn()
  {
     Application.Quit();
     Debug.Log("Exit Button Pressed");
  }
}
