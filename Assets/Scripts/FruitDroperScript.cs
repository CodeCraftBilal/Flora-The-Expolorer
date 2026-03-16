using Unity.Mathematics;
using UnityEngine;

public class FruitDroperScript : MonoBehaviour
{
    public GameObject[] fruits;
    public float minX = -8f;
    public float maxX = 8f;
    public float minY = 6f;
    public float maxY = -6f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        InvokeRepeating("dropFruits", 0.1f, 1f);
    }

    void dropFruits()
    { 
        for(int i = 0; i<=3; i++)
        {
            
        int randomIndex = UnityEngine.Random.Range(0, fruits.Length);

        Instantiate(fruits[randomIndex], new Vector3(UnityEngine.Random.Range(minX, maxX),UnityEngine.Random.Range(minY, maxY),0f), quaternion.identity);
        }
        
    }
}
