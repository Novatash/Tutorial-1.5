using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatController : MonoBehaviour
{
    public AudioSource musicSource;

    public AudioClip musicOne;
    public AudioClip musicTwo;

    Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("escape"))
        {
            Application.Quit();
        }

        if (Input.GetKeyDown(KeyCode.W))
        {
            musicSource.clip = musicOne;
            musicSource.Play();
            anim.SetInteger("State", 1);
        }
        if (Input.GetKeyUp(KeyCode.W))
        {
            if (musicSource.clip == musicOne)
            {
                musicSource.Stop();
                anim.SetInteger("State", 0);
            }
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            musicSource.clip = musicTwo;
            musicSource.Play();
            anim.SetInteger("State", 2);
        }
        if (Input.GetKeyUp(KeyCode.R))
        {
            if (musicSource.clip == musicTwo)
            {
                musicSource.Stop();
                anim.SetInteger("State", 0);
            }
        }
    }
}
