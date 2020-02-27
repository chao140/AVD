using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    public float speed = 20f;
    public int damage = 40;
    public Rigidbody2D rb;
//    public GameObject impactEffect;
    
    void Start(){
//        Debug.Log(transform.name);
        GameObject player = GameObject.Find("PLAYER");
        rb.velocity = player.transform.right * speed;
    }

    void OnTriggerEnter2D(Collider2D hitInfo)
    {
//        Debug.Log(hitInfo.name);
//       Debug.Log(rb.velocity);
        if((hitInfo.name).Equals("PLAYER")) {
            return;
        }

        
        Enemy enemy = hitInfo.GetComponent<Enemy>();
        
        if (enemy != null)
        {
            enemy.TakeDamage(damage);
        }
//        Instantiate(impactEffect, transform.position, transform.rotation);
        Destroy(gameObject);
//        Debug.Log(gameObject.name);
    }
}
