using System;
using UnityEngine;
using UnityEngine.UI;

public class DisplayImage : MonoBehaviour
{
    private DataManager dataManager;
    public Image imageViewer;
    private Sprite[] sprite;
    private int index = 0;
    private string path;

    void Start()
    {
        path = DataManager.instance.path;
        Debug.Log("Path: " + path);
        LoadImages(path);
    }

    public void LoadImages(string path)
    {
        sprite = Resources.LoadAll<Sprite>(path);
        index = 0;
        imageViewer.sprite = sprite[index];
    }

    public void OnClickNext()
    {
        Debug.Log("Next is Clicked");
        index++;
        index %= sprite.Length;
        imageViewer.sprite = sprite[index];
    }
    
    public void OnClickPrevious()
    {
        Debug.Log("Previous is Clicked");   
        index = (index -1 + sprite.Length) % sprite.Length;
        imageViewer.sprite = sprite[index];
    }

    public void OnBack()
    {
        SceneController.instance.GoBack();
    }

    public void OnHome()
    {
        SceneController.instance.GoHome();
    }
}
