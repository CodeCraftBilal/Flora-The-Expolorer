using UnityEngine;

public class DataManager : MonoBehaviour
{

    private static DataManager _instance;
    public static DataManager instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = FindObjectOfType<DataManager>();
                if (_instance == null)
                {
                    GameObject go = new GameObject("DataManager");
                    _instance = go.AddComponent<DataManager>();
                    // DontDestroyOnLoad will be called in Awake, which is triggered by AddComponent
                }
            }
            return _instance;
        }
    }

    public string path;
    
    // Level selection and game state variables
    public string targetFruitName = "Banana"; // default for level 1
    public int scoreToWin = 3;
    public int currentScore = 0;
    public bool isRightFruitClicked = true;

    void Awake()
    {
        if(_instance == null)
        {
            _instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else if (_instance != this)
        {
            Destroy(gameObject);
        }
    }
}
