using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserScript : MonoBehaviour
{
    public Transform impactPrefab;
    public float lifeTime = 5;

    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, lifeTime);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision other)
    {
        if(other.transform.tag == "Enemy")
        {
            Instantiate(impactPrefab, transform.position, Quaternion.identity);
            Destroy(gameObject, 0.01f);
        }
            
    }
}
