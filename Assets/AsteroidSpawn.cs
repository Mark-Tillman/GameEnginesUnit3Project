using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidSpawn : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Rigidbody>().mass *= transform.localScale.x;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
