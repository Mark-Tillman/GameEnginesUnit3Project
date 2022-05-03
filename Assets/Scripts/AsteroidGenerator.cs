using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidGenerator : MonoBehaviour
{

    public Transform asteroidPrefab;
    public int fieldRadius = 100;
    public int asteroidCount = 500;
    public Vector3 maxSize = new Vector3(10, 10, 10);
    public float maxSpeed = 50;

    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i < asteroidCount; i++)
        {
            Transform asteroid = Instantiate(asteroidPrefab, Random.insideUnitSphere * fieldRadius, Quaternion.identity);
            asteroid.localScale = Random.value * maxSize;
            asteroid.GetComponent<Rigidbody>().AddForce(new Vector3(Random.rotation.x * maxSpeed, Random.rotation.y * maxSpeed, Random.rotation.z * maxSpeed));
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
