using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class menu : MonoBehaviour
{
    public GameObject lvl, menu_;
    void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            lvl.SetActive(false);
            menu_.SetActive(true);
        }
    }
}
