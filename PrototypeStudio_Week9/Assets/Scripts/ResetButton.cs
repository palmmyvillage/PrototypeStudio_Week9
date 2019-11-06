using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ResetButton : MonoBehaviour
{
    public static ResetButton instance;
    public KeyCode resetSceneButton, resetGameButton, quitGameButton, nextSceneButton;
    public bool nextScene_enable;

    void Awake()
    {
        if (instance == null)
        {
            DontDestroyOnLoad(gameObject);
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(resetSceneButton))
            ResetScene();
        if (Input.GetKeyDown(resetGameButton))
            ResetGame();
        if (Input.GetKeyDown(quitGameButton))
            QuitGame();

        if (Input.GetKeyDown(nextSceneButton))
        {
            if (nextScene_enable == true)
                GoNextScene();
        }
        
    }

    void ResetScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    void ResetGame()
    {
        SceneManager.LoadScene(0);
    }

    void QuitGame()
    {
        Application.Quit();
    }

    void GoNextScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
