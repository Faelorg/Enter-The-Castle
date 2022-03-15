using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class button : MonoBehaviour
{
    public AudioSource point;
    public AudioSource notpoint;
    public GameObject point1, notpoint1;
    public bool p;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "statuya")
        {
            point.Play();
            notpoint1.SetActive(false);
            point1.SetActive(true);
            p = true;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "statuya")
        {
            notpoint.Play();
            point1.SetActive(false);
            notpoint1.SetActive(true);
            p = false;
        }
    }
}
