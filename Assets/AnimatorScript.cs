using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorScript : MonoBehaviour
{
    public Animator anim;

    void Start()
    {

    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (anim.GetBool("bool") == false)
            {
                anim.SetBool("bool", true);
            }
            else
            {
                anim.SetBool("bool", false);
            }
        }
        if (Input.GetKeyDown(KeyCode.Return))
        {
            anim.SetTrigger("trigger");
        }
    }
}
