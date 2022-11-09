using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animationController : MonoBehaviour
{
    public Animator animator;

    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            Debug.Log("I am jumping!");
            animator.SetBool("jumping", true);
        }
        else if (Input.GetButtonUp("Jump"))
        {
            Debug.Log("I have stopped jumping!");
            animator.SetBool("jumping", false);
        } 
        // first value is the variable thats being changed
        // second value is the value that will go into the variable
        // so here, horizontal will now hold to value of input.getaxis(blah blah blah)

        //animator.SetInteger("horizontal", Mathf.RoundToInt(Input.GetAxis("Horizontal")));
        //animator.SetInteger("vertical", Mathf.RoundToInt(Input.GetAxis("Vertical")));
    }
}
