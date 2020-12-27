using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitlePlayer : MonoBehaviour
{
    Animator animator;
    AudioSource audiosource;
    public AudioClip sound1;
    //sound2,3は予備
    public AudioClip sound2;
    public AudioClip sound3;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        audiosource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if(SceneManager.GetActiveScene().name == "Title")
        {
            if (Input.GetKeyDown(KeyCode.Return))
            {
                audiosource.PlayOneShot(sound1);
                animator.SetBool("Start", true);
            }
        }
        if (SceneManager.GetActiveScene().name == "Win")
        {
            if (Input.GetKeyDown(KeyCode.Return))
            {
                audiosource.PlayOneShot(sound1);
                animator.SetBool("Title", true);
            }
        }
        if (SceneManager.GetActiveScene().name == "Lose")
        {
            if (Input.GetKeyDown(KeyCode.Return))
            {
                audiosource.PlayOneShot(sound1);
                animator.SetBool("Title", true);
            }
        }
    }
}
