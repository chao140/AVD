using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cherry : MonoBehaviour
{
public GameObject deathEffect;

   void OnCollisionEnter2D(Collision2D col)
{
	if (col.gameObject.tag == "cherry")
	{
		Destroy(col.gameObject);
        Die();
	}
    void Die ()
    {
        Instantiate(deathEffect, transform.position, Quaternion.identity);
       
    }
}
}
