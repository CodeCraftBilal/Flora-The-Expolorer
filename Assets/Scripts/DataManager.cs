using UnityEngine;

public class DataManager : MonoBehaviour
{

    public static DataManager instance;
    public string path;

    void Awake()
    {
        if(instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
