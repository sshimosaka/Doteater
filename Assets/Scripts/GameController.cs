using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Escape)) Quit();
    }

    void Quit(){
        //UnityEditor.EditorApplication.isPlaying = false;
        UnityEngine.Application.Quit();
    }
}
