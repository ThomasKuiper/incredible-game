using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Hitting : MonoBehaviour
{

    public float damage;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag != "Player" && collision.tag != "EnemySpell" && collision.tag != "PlayerSpell")
        {
            if (collision.tag == "Enemy")
            {
                collision.gameObject.GetComponent<Health>().takeDamage(damage);
            }
            Destroy(gameObject);
        }
    }
/*
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

    void OnTriggerEnter2D(Collision2D collision)
    {
        if (!collision.gameObject.CompareTag("Player") && !collision.gameObject.CompareTag("PlayerSpell")) {
            if (collision.gameObject.CompareTag("Enemy"))
            {
                collision.gameObject.GetComponent<Health>().takeDamage(damage);
            }
            Destroy(gameObject);
        }
    }*/
}
