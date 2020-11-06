using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scenes : MonoBehaviour
{
    public void Scene1To0()
    {
        SceneManager.LoadScene(0);
    }
    public void Scene0To1()
    {
        SceneManager.LoadScene(1);
    }

    public void Scene1To2()
    {
        SceneManager.LoadScene(2);
    }

    public void Scene2To1()
    {
        SceneManager.LoadScene(1);
    }

    public void Scene1To3()
    {
        SceneManager.LoadScene(3);
    }
}
