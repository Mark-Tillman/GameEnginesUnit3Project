using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidScript : MonoBehaviour
{
    public Transform explosionPrefab;
    private float maxHealth;
    private float currentHealth;

    public float damageToTake = 0.1f;

    // Start is called before the first frame update
    void Start()
    {
        maxHealth = transform.localScale.x / 15;
        currentHealth = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision other)
    {
        if(other.transform.tag == "Laser")
        {
            currentHealth -= damageToTake;
            if(currentHealth <= 0)
            {
                Transform explosion = Instantiate(explosionPrefab, transform.position, Quaternion.identity);
                explosion.localScale *= transform.localScale.x / 2;
                explosion.GetChild(0).transform.localScale = explosion.localScale;
                Destroy(explosion.gameObject, 5);
                Destroy(gameObject, 0.01f);
            }

        }
            
    }
}
