using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    private static SceneController _instance;
    public static SceneController instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = FindObjectOfType<SceneController>();
                if (_instance == null)
                {
                    GameObject go = new GameObject("SceneController");
                    _instance = go.AddComponent<SceneController>();
                    // DontDestroyOnLoad handles internally on Awake
                }
            }
            return _instance;
        }
    }

    private Stack<string> sceneHistory = new Stack<string>();

    void Awake()
    {
        if (_instance == null)
        {
            _instance = this;
            DontDestroyOnLoad(gameObject);
            sceneHistory.Push(SceneManager.GetActiveScene().name);
        }
        else if (_instance != this)
        {
            Destroy(gameObject);
        }
    }

    public void LoadScene(string sceneName)
    {
        string currentScene = SceneManager.GetActiveScene().name;
        sceneHistory.Push(sceneName);
        SceneManager.LoadScene(sceneName);
        PrintSceneHistory();
    }

    public void GoBack()
    {
        sceneHistory.Pop();
        string previouseScene = sceneHistory.Peek();
        SceneManager.LoadScene(previouseScene);
        PrintSceneHistory();
    }

    public void PopScene(int NoOfSceneToDestroy)
    {
        for (int i = 0; i < NoOfSceneToDestroy; i++)
        {
            if (sceneHistory.Count > 0)
            {
                sceneHistory.Pop();
                PrintSceneHistory();
            }
        }
    }

    public void PopAll()
    {
        Debug.Log("Popall is running. Total Scenes: " + sceneHistory.Count);
        while (sceneHistory.Count > 0)
        {
            Debug.Log("Poping " + sceneHistory.Peek());
            PopScene(1);
        }
    }

    private void PrintSceneHistory()
    {
        Debug.Log("Scene History: [" + string.Join(", ", sceneHistory) + "]");
    }
}
