using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagment : MonoBehaviour
{
    public static SceneManagment Instance;
    private Stack<Scene> sceneStack = new Stack<Scene>();
    private Scene currentScene;
    MusicPlayer musicPlayer;

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
            Destroy(this.gameObject);

        DontDestroyOnLoad(gameObject);

        musicPlayer = GetComponentInChildren<MusicPlayer>();
        StartCoroutine(PlayMenuSceneMusic());
        UpdateCurrentScene();
    }

    void Update()
    {
        if (Input.GetKey("escape"))
        {
            if (currentScene.name == "StartScene")
                ExitApp();
            else
            {
                //OpenScene(sceneStack.Peek().name);
                Debug.Log(sceneStack.Peek().name);
                sceneStack.Pop();
                OpenScene(sceneStack.Peek().name);
            }
        }
    }

    IEnumerator PlayMenuSceneMusic()
    {
        yield return new WaitForSeconds(.1f);
        musicPlayer.PlayMusic(MusicCollectionEnum.MenuScene);
    }

    public void OpenGame(string buttonName)
    {
        if(buttonName == "Game1Button")
        {
            OpenScene("Game1Scene");
        }
        else if(buttonName == "Game2Button")
        {
            OpenScene("Game2Scene");
        }
        else if (buttonName == "Game3Button")
        {
            OpenScene("Game3Scene");
        }
        else if (buttonName == "Game4Button")
        {
            OpenScene("Game4Scene");
        }
        else if (buttonName == "Game5Button")
        {
            OpenScene("Game5Scene");
        }
    }

    public void OpenMenuScene()
    {
        OpenScene("MenuScene");
    }

    private void OpenScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);    
        StartCoroutine(FillSceneStack());
    }

    public void ExitApp()
    {
        Application.Quit();
    }   

    private void UpdateCurrentScene()
    {
        currentScene = SceneManager.GetActiveScene();
    }

    IEnumerator FillSceneStack()
    {
        yield return new WaitForSeconds(.2f);
        UpdateCurrentScene();
        Debug.Log(currentScene.name);
        sceneStack.Push(currentScene);
    }
}
