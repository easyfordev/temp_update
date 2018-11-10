using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class changeScenes : MonoBehaviour
{

    public void Scene_main()
    {
        SceneManager.LoadScene("main");
    }
    public void Scene_copresence()
    {
        SceneManager.LoadScene("copresence");
    }
    public void Scene_entertainment()
    {
        SceneManager.LoadScene("entertainment");
    }
    public void Scene_route()
    {
        SceneManager.LoadScene("travel_route");
    }
    public void Scene_info()
    {
        SceneManager.LoadScene("travel_info");
    }
    public void Scene_karaoke()
    {
        SceneManager.LoadScene("karaoke");
    }
    public void Scene_src_dest()
    {
        SceneManager.LoadScene("set_src_dest");
    }
}
