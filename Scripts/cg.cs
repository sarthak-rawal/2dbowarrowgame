using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class cg : MonoBehaviour

{
    // The name of the scene to load
    public string sceneName;

    // Delay before changing scene (in seconds)
    public float delay = 5f;

    void Start()
    {
        // Invoke the ChangeScene method after the specified delay
        Invoke("ChangeScene", delay);
    }

    void ChangeScene()
    {
        // Load the specified scene
        SceneManager.LoadScene(1);
    }
}

