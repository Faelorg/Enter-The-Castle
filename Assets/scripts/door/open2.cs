using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class open2 : MonoBehaviour
{
    public GameObject door_o, door_c;
     public GameObject[] button;
    public AudioSource door_o1, door_c1;
    public bool[] k;
    private void Start()
    {
        door_c1.Stop();
    }
    void searchbutton()
    {
        k[0] = button[0].GetComponent<button>().p;
        k[1] = button[1].GetComponent<button>().p;
    }
    void Update()
    {
        searchbutton();

        if (k[0] && k[1])
        {
            door_o.SetActive(true);
            door_c.SetActive(false);
            door_o1.Play();
        }
            if (k[0] == false || k[1] == false)
            {
                door_c.SetActive(true);
                door_o.SetActive(false);
                door_c1.Play();
            }
        }
}
