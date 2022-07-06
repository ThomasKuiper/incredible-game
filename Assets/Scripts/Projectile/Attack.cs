using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour
{
    public GameObject kunaiPrefab;
    public Camera cam;
    private Vector3 playerPos;
    public float kunaiSpeed;
    private float colliderRad;
    void Start()
    {
        colliderRad = 0.7f;//gameObject.GetComponent<CircleCollider2D>().radius;
    }

    // Update is called once per frame
    void Update()
    {
        playerPos = gameObject.transform.position;
        if (Input.GetButtonDown("Fire1"))
        {
            ThrowKunai();
        }
    }

    void ThrowKunai()
    {
        Vector3 mousePos = cam.ScreenToWorldPoint(Input.mousePosition);
        Vector2 direction = mousePos - playerPos;
        //coordinates to make sure the kunai spawns outside of the hitbox of the player
        float adjustX = direction.normalized.x * colliderRad;
        float adjustY = direction.normalized.y * colliderRad;
        Vector3 spawnPos = playerPos + new Vector3(adjustX, adjustY);
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg - 90f;
        GameObject kunai = Instantiate(kunaiPrefab, spawnPos, Quaternion.Euler(new Vector3(0, 0, angle)));
        Rigidbody2D rb = kunai.GetComponent<Rigidbody2D>();
        rb.AddForce(direction * kunaiSpeed, ForceMode2D.Impulse);
    }
}
