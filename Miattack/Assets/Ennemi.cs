using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Ennemi : MonoBehaviour
{
    public GameObject deathEffect;
    public float health = 4f;
    public static int EnnemisAlive = 0;

    void Start ()
    {
        EnnemisAlive++;
    }

    void OnCollisionEnter2D (Collision2D colInfo)
    {
        if (colInfo.relativeVelocity.magnitude > health)
        {
            Die();
        }
    }

    
    void Die ()
    {
        GameObject particle = Instantiate(deathEffect, transform.position, Quaternion.identity);

        particle.SetActive(true);

        EnnemisAlive--;
        if (EnnemisAlive<=0)
        
        Destroy(gameObject);
    
    }
}
