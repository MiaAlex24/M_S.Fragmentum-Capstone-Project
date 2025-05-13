using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
  public void NextRoom(int sceneIndex)
    {
        SceneManager.LoadSceneAsync(sceneIndex);
    }

    public void OnApplicationQuit()
    {
        Application.Quit();
    }
}
