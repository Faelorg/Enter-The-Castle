using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class setting : MonoBehaviour
{
    public GameObject setting_;
    public void Update()
    {
      setting_ = GameObject.Find("setting(1)");
    }
}
