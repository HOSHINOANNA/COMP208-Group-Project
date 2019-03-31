using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animationController : MonoBehaviour
{
    public Animator animator;



    private Transform tr;
    private Vector3 localVelocity;

    private Vector3 lastPosition;

    // Start is called before the first frame update
    void Start()
    {
        animator = this.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        // MOVEMENT KEYBOARD CONTROLLER
        if (Input.GetKeyDown(KeyCode.W))
        {
            animator.SetBool("Walk", true);

            gameController();

        }
        if (Input.GetKeyUp(KeyCode.W))
        {
            animator.SetBool("Walk", false);

        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            animator.SetBool("Walk", true);

        }


        if (Input.GetKeyUp(KeyCode.S))
        {
            animator.SetBool("Walk", false);

        }

        gameController();
        // ATTACK WING KEYBOARD CONTROLLER

    }

    void gameController()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            animator.SetBool("Atk1_wing", true);
        }
        if (Input.GetKeyUp(KeyCode.Q))
        {
            animator.SetBool("Atk1_wing", false);
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            animator.SetBool("Atk2_wing", true);
        }
        if (Input.GetKeyUp(KeyCode.E))
        {
            animator.SetBool("Atk2_wing", false);
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            animator.SetBool("Atk3_wing", true);
        }
        if (Input.GetKeyUp(KeyCode.R))
        {
            animator.SetBool("Atk3_wing", false);
        }
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            animator.SetBool("Run", true);
        }
        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            animator.SetBool("Run", false);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            animator.SetBool("Jump", true);
        }
        if (Input.GetKeyUp(KeyCode.Space))
        {
            animator.SetBool("Jump", false);
        }

    }
}
