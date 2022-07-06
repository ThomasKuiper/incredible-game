using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hitting : MonoBehaviour
{
    private float damage;
    private BoxCollider2D bc2d;
    // Start is called before the first frame update
    void Start()
    {
        damage = 10;
        bc2d = gameObject.GetComponent<BoxCollider2D>();
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Enemy"))
        {
            collision.gameObject.GetComponent<Health>().takeDamage(damage);
        }
 //       if (collision.gameObject.CompareTag("Player"))
 //       {
 //           PlayerStats.playerStats.DealDamage(damage);
 //       }
        Destroy(gameObject);
    }
}
