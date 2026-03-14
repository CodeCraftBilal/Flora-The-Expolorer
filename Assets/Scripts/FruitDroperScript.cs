using Unity.Mathematics;
using UnityEngine;

public class FruitDroperScript : MonoBehaviour
{
    public GameObject[] fruits;
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

        Instantiate(fruits[randomIndex], new Vector3(UnityEngine.Random.Range(-12.5f, 12.5f),UnityEngine.Random.Range(6.10f, 12f),0f), quaternion.identity);
        }
        
    }
}
