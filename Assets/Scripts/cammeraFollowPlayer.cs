using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cammeraFollowPlayer : MonoBehaviour
{
    public Transform player;
    public float smooth;
    public Vector3 offset;

    private void FixedUpdate()
    {
        if(player != null)
        {
            Vector3 newPosition = Vector3.Lerp(transform.position, player.transform.position + offset, smooth);
            transform.position = newPosition;
        }
        
    }

}