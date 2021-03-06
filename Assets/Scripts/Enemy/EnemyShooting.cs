using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShooting : MonoBehaviour
{
    public GameObject projectile;
    //need to link to player object in the scene
    public Transform player;

    public float minDamage;
    public float maxDamage;
    public float projectileForce;
    public float cooldown;

    private void Start()
    {
        StartCoroutine(ShootPlayer());
    }

    IEnumerator ShootPlayer()
    {
        yield return new WaitForSeconds(cooldown);
        if (player != null)
        {
            GameObject spell = Instantiate(projectile, transform.position, Quaternion.identity);
            Vector2 myPos = transform.position;
            Vector2 targetPos = player.position;
            Vector2 direction = (targetPos - myPos).normalized;
            spell.GetComponent<Rigidbody2D>().velocity = direction * projectileForce;
            spell.GetComponent<EnemySpell>().damage = Random.Range(minDamage, maxDamage);
            StartCoroutine(ShootPlayer());
        }
    }
}
