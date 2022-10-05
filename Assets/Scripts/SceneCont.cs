using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneCont : MonoBehaviour
{
    public string gameScreen;

    public void ChangeScene()
    {
        SceneManager.LoadScene(gameScreen);
    }
}
