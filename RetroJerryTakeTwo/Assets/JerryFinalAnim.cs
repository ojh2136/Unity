using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JerryFinalAnim : MonoBehaviour {

    private Animator anim;

    private void Start()
    {
        anim = GetComponent<Animator>();
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.RightArrow))
        {
            anim.SetBool("IsRunning", true);
        } else
        {
            anim.SetBool("IsRunning", false);
        }

        if ((Input.GetKey(KeyCode.UpArrow)) ) {
            anim.SetBool("IsJumping", true);
        } else
        {
            anim.SetBool("IsJumping", false);        
            }



        


    }
}
