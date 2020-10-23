using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.SceneManagement;
using UnityEngine.SceneManagement;

public class MenuToPlay : MonoBehaviour
{
    public void Scene1To3()
    {
        SceneManager.LoadScene(3);
    }
}
