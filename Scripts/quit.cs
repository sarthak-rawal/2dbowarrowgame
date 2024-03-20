using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class quit : MonoBehaviour
{
    public void quitbtn()
    {
        Application.Quit();
        /* EditorApplication.isPlaying = false;*/
    }
}
