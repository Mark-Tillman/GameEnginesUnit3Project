using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidGenerator : MonoBehaviour
{

    public Transform asteroidPrefab;
    public int fieldRadius = 100;
    public int asteroidCount = 500;
    public Vector3 maxSize = new Vector3(10, 10, 10);

    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i < asteroidCount; i++)
        {
            Instantiate(asteroidPrefab, Random.insideUnitSphere * fieldRadius, Quaternion.identity);
            asteroidPrefab.transform.localScale = Random.value * maxSize;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
