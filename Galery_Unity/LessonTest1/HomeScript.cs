using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HomeScript : MonoBehaviour
{
    public int sceneNumber;
    public void Scene3()
    {
        SceneManager.LoadScene(sceneNumber);
    }
}
