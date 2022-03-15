using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class touch : MonoBehaviour
{
    private Rigidbody2D stat;

    private void Start()
    {
        stat = GetComponent<Rigidbody2D>();
        stat.Sleep();
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.collider.tag == "Player" || collision.collider.tag == "ENEMY")
        {
            stat.velocity = new Vector2(stat.velocity.x * 0, stat.velocity.x * 0);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
