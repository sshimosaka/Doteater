using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    public string nextSceneName;
    AudioSource enterSound;
    private void Start()
    {
        enterSound = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (SceneManager.GetActiveScene().name == "Title")
        {
            if (Input.GetButtonDown("Submit"))
            {
                enterSound.Play();
                Invoke("NextToScene", 2.6f);
            }
        }
        if (SceneManager.GetActiveScene().name == "Win")
        {
            if (Input.GetButtonDown("Submit"))
            {
                enterSound.Play();
                Invoke("NextToScene", 3.3f);
            }
        }
        if (SceneManager.GetActiveScene().name == "Lose")
        {
            if (Input.GetButtonDown("Submit"))
            {
                enterSound.Play();
                Invoke("NextToScene", 2.3f);
            }
        }
    }

    void NextToScene()
    {
        SceneManager.LoadScene(nextSceneName);
    }
}
