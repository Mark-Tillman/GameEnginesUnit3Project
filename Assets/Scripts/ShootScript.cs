using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine;

public class ShootScript : MonoBehaviour
{
    public Transform laserPrefab;
    public Transform leftGun;
    public Transform rightGun;
    public float shootVelocity;
    public bool shooting = false;
    private bool canShoot = true;
    public float fireCooldown;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(shooting && canShoot)
        {
            canShoot = false;
            StartCoroutine(ShootCooldown());
            Shoot();
        }

    }

    void OnShoot(InputValue value)
    {
        shooting = !shooting;
    }

    void Shoot()
    {
        Transform laser1 = Instantiate(laserPrefab, leftGun.position, transform.rotation);
        laser1.GetComponent<Rigidbody>().AddForce(laser1.transform.forward * shootVelocity);

        Transform laser2 = Instantiate(laserPrefab, rightGun.position, transform.rotation);
        laser2.GetComponent<Rigidbody>().AddForce(laser2.transform.forward * shootVelocity);
    }

    IEnumerator ShootCooldown()
    {
        yield return new WaitForSeconds(fireCooldown);
        canShoot = true;
    }
}
