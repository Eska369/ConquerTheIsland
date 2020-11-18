using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class crouch : MonoBehaviour
{
    public Animator animator;


    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            animator.SetBool("crouch",true);
        }

        if(Input.GetKeyUp(KeyCode.S))
        {
            animator.SetBool("crouch", false);
        }
    }
}
