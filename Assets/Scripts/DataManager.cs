using UnityEngine;

public class DataManager : MonoBehaviour
{

    public DataManager instance;
    public string selected;

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
