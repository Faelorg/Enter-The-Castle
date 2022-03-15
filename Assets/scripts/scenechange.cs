using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class scenechange : MonoBehaviour
{
    public string[] lvl;
    public GameObject setting, setting1;
    public void menu()
    {
        SceneManager.LoadScene("menu", LoadSceneMode.Single);
    }
    public void start()
    {
        PlayerPrefs.DeleteKey("next");
        SceneManager.LoadScene(lvl[0], LoadSceneMode.Single);
    }
    public void cont()
    {
        SceneManager.LoadScene(lvl[PlayerPrefs.GetInt("next")], LoadSceneMode.Single);
    }
    public void Exit()
    {
        Application.Quit();
        PlayerPrefs.Save();
    }
}
