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
        sceneHistory.Push(currentScene);
        SceneManager.LoadScene(sceneName);
        Debug.Log("Scence History: "+ sceneHistory);
    }

    public void GoBack()
    {
        sceneHistory.Pop();
        string previouseScene = sceneHistory.Peek();
        SceneManager.LoadScene(previouseScene);
    }

    public void PopScene()
    {
        if (sceneHistory.Count > 0)
        {
            sceneHistory.Pop();
        }
    }
}
