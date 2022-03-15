using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class open : MonoBehaviour
{
    public GameObject door_o, door_c, button;
    public AudioSource door_o1, door_c1;
    public bool x;
    public bool k;
    void searchbutton()
    {
        k = button.GetComponent<button>().p;
    }
    private void Start()
    {
        door_c1.Stop();
    }
    void Update()
    {
        searchbutton();
       
            if (k)
        {
            door_o.SetActive(true);
            door_c.SetActive(false);
            door_o1.Play();
        }
            if (k == false)
        {
            door_c.SetActive(true);
            door_o.SetActive(false); 
            door_c1.Play();
            x = false;
        }
    }
}
