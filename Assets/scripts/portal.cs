using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class portal : MonoBehaviour
{
    public string[] lvl;
    public float dt;
    public int t;
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            dt += Time.deltaTime;
            if (dt >= 0.5)
            {
                t += 1;
                dt = 0;
            }
            if (t == 1)
            {
                SceneManager.LoadScene(lvl[PlayerPrefs.GetInt("next")]);
            }
        }
    }
    
}
