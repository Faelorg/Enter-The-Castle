using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class music : MonoBehaviour
{
    private void Start()
    {
        volume.value = PlayerPrefs.GetFloat(n);
    }
    public float auto;
    public Slider volume;
    public string n = "volume";
    private void Update()
    {
        auto = volume.value;
    }
    public void Musicsave()
    {
        PlayerPrefs.SetFloat(n, auto);
    }
    public void MusicLoad()
    {
        volume.value = PlayerPrefs.GetFloat(n);
    }
}
