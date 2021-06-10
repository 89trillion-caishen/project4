using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    private Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator=GetComponent<Animator>();
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            animator.SetTrigger("isAttack");
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            animator.SetTrigger("isRun");
        }
        if (Input.GetKeyDown(KeyCode.I))
        {
            animator.SetTrigger("isIdle");
        }
    }
}
