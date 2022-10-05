using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneCont : MonoBehaviour
{
    void GameScene()
    {
        SceneManager.LoadScene("MainScreen");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space")) //if space is pressed down:
        {
            GameScene();
        }
    }
}
