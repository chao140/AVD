using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class weapon : MonoBehaviour
{
    public Transform fire;
    public GameObject bulletPrefab;
    public int damage = 40;
    public GameObject impactEffect;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }
    void Shoot()
    {
        RaycastHit2D hitInfo = Physics2D.Raycast(fire.position, fire.right);

        if (hitInfo)
        {
            Enemy Enemy = hitInfo.transform.GetComponent<Enemy>();
            if(Enemy != null)
            {
                Enemy.TakeDamage(damage);
            }
            Instantiate(impactEffect, hitInfo.point, Quaternion.identity);
        }
       // Instantiate(bulletPrefab, fire.position, fire.rotation);
    }
}
