using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ai : MonoBehaviour
{
    public Rigidbody2D enemy;
    public Rigidbody2D player;
    private Vector2 dist;
    public float speed;
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            dist = GameObject.FindWithTag("Player").transform.position - enemy.transform.position;
            enemy.velocity = dist * speed;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            enemy.velocity = new Vector2(0f, 0f);
        }
    }
}

// git change