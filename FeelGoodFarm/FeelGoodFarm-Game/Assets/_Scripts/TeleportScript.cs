using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportScript : MonoBehaviour
{
    [SerializeField]
    private Vector2 teleportPosition;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Collision tag house:" + collision.tag);
        if (collision.tag == "Player")
        {
            collision.gameObject.GetComponent<Rigidbody2D>().MovePosition(teleportPosition);
        }
    }
}
