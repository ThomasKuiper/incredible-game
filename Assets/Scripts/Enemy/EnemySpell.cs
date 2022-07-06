using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpell : MonoBehaviour
{

    public float damage;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag != "Enemy")
        {
            if (collision.tag == "Player")
            {
                print("hit");
                PlayerStats.playerStats.DealDamage(damage);
            }
            Destroy(gameObject);
        }
    }

    //   public float damage;
    //   private BoxCollider2D bc2d;
    // Start is called before the first frame update
    //   void Start()
    //   {
    //       damage = 10;
    //       bc2d = gameObject.GetComponent<BoxCollider2D>();
    //   }

    //   void OnCollisionEnter2D(Collision2D collision)
    //   {
    //       if (collision.gameObject.tag != "Enemy")
    //       {
    //           if (collision.gameObject.CompareTag("Player"))
    //           {
    //               PlayerStats.playerStats.DealDamage(damage);
    //           }
    //           Destroy(gameObject);
    //       }
    //   }
}
