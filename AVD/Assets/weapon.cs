using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class weapon : MonoBehaviour
{
    public Transform fire;
    public GameObject bulletPrefab; 
//    public LineRenderer lineRenderer;
    public int damage = 40;
    public GameObject impactEffect;

    // Update is called once per frame
    void Update()
    {
//        Debug.Log(fire.transform.position);
        if(Input.GetButtonDown("Fire1"))
        {
            Shoot();
//            StartCoroutine(Shoot());
        }
    }
    void Shoot()
    {
        RaycastHit2D hitInfo = Physics2D.Raycast(fire.position, fire.right);

        if (hitInfo)
        {
            Enemy enemy = hitInfo.transform.GetComponent<Enemy>();
            if(enemy != null)
            {
                enemy.TakeDamage(damage);
            }
            Instantiate(impactEffect, hitInfo.point, Quaternion.identity);

//            lineRenderer.SetPosition(0, fire.position);
//            lineRenderer.SetPosition(1, hitInfo.point);
        }
//        else
//        {
//            lineRenderer.SetPosition(0, fire.position);
//            lineRenderer.SetPosition(1, fire.position + fire.right * 100);
//        }
//        lineRenderer.enabled = true;

//        yield return 0;

//        lineRenderer.enabled = false;
        // Instantiate(bulletPrefab, fire.position, fire.rotation);

    }
}