using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    private Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("start");
        animator=GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            Debug.Log("A1");
            animator.SetBool("Attack",true);
            animator.SetBool("Run",false);
            animator.SetBool("Idle",false);
        }

        if (Input.GetKey(KeyCode.I))
        {
            Debug.Log("I");
            animator.SetBool("Run",false);
            animator.SetBool("Idle",true);
            animator.SetBool("Attack",false);
        }

        if (Input.GetKey(KeyCode.R))
        {
            Debug.Log("R");
            animator.SetBool("Run",true);
            animator.SetBool("Idle",false);
            animator.SetBool("Attack",false);
        }
    }
}
