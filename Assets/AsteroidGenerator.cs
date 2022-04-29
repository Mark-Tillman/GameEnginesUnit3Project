using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidGenerator : MonoBehaviour
{

    public Transform asteroidPrefab;
    public int fieldRadius = 100;
    public int asteroidCount = 500;

    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i < asteroidCount; i++)
        {
            Instantiate(asteroidPrefab, Random.insideUnitSphere * fieldRadius, Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
