using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class walk : MonoBehaviour
{
    public Vector2 speed = new Vector2(20f, 20f);
    public float X;
    public float y;
    private Vector2 top;
    public Rigidbody2D rd;
    void Update()
    {
        lgmove();
        mov();
        rd.velocity = top;
    }
    void mov()
    {
        top = new Vector2(speed.x * X, speed.y * y);
    }
    void lgmove()
    {
        X = Input.GetAxis("Horizontal");
        y = Input.GetAxis("Vertical");
    }
}
