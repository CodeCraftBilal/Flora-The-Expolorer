using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    public static SceneController instance;
    private Stack<string> sceneHistory = new Stack<string>();

    void Awake()
    {
        if(instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
            sceneHistory.Push(SceneManager.GetActiveScene().name);
        } else
        {
            Destroy(gameObject);
        }
    }

    public void LoadScene(string sceneName)
    {
        sceneHistory.Push(sceneName);
        SceneManager.LoadScene(sceneName);
    }

    public void GoBack()
    {
        sceneHistory.Pop();
        string previouseScene = sceneHistory.Peek();
        SceneManager.LoadScene(previouseScene);
    }
}
