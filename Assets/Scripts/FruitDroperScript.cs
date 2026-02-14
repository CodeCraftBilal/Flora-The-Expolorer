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
        int randomIndex = UnityEngine.Random.Range(1, fruits.Length);

        Instantiate(fruits[randomIndex], new Vector3(UnityEngine.Random.Range(-12.5f, 12.5f),6.10f,0f), quaternion.identity);
        
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
