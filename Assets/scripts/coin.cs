using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class coin : MonoBehaviour
{
    public Text text;
    public int k;
    public int max;
    public AudioSource m;
    public GameObject portal;
    private bool x = true;
    private int k1 = 0;
    public int k2;
    public GameObject p;
    void Start()
    {
        text.text = 0 + k + "/" + max;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "coin")
        {
            Destroy(collision.gameObject);
            k++;
            text.text = k + "/" + max;
            m.Play();
        }
    }
    void Update()
    {
        if (k == max && x)
        {
            k1 = PlayerPrefs.GetInt("next");
            k1++;
            k2 = k1;
            PlayerPrefs.SetInt("next", k2);
            Instantiate(portal).transform.position = p.transform.position;
            x = false;
            }
        }
    }

