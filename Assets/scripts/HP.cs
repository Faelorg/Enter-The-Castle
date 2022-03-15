using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HP : MonoBehaviour
{
    public int hp = 2;
    public string tag_;
    public GameObject[] heart;
    public float dt;
    public int t;
    void Start()
    {

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == tag_)
        {
            Destroy(heart[hp]);
            hp = hp - 1;
        }
    }
    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.collider.tag == tag_)
        {
            dt += Time.deltaTime;
            if (dt >= 1.5)
            {
                t += 1;
                dt = 0;
            }
            if (t == 2)
            {
                Destroy(heart[hp]);
                hp = hp - 1;
                t = 0;
            }
        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.collider.tag == tag_ )
        {
            t = 0;
            dt = 0;
        }
    }
    void Update()
    {
        if (hp <= -1)
        {
            SceneManager.LoadScene("death", LoadSceneMode.Single);
        }
    }
}
