using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animationController : MonoBehaviour
{
    public Animator animator;

    private Transform tr;
    private Vector3 localVelocity;

    private Vector3 lastPosition;
    private bool up = true;
    private bool down = true;
    private bool left = true;
    private bool right = true;
  

    // Start is called before the first frame update
    void Start()
    {

        animator = this.GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftShift)){
            if (Input.GetKeyDown(KeyCode.A))
            {
                animator.SetBool("Run", true);
            } }
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            if (Input.GetKeyDown(KeyCode.W))
            {
                animator.SetBool("Run", true);
            }
        }
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            if (Input.GetKeyDown(KeyCode.S))
            {
                animator.SetBool("Run", true);
            }
        }
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            if (Input.GetKeyDown(KeyCode.D))
            {
                animator.SetBool("Run", true);
            }
        }
        // MOVEMENT KEYBOARD CONTROLLER
        if (Input.GetKeyDown(KeyCode.W))
        {
            animator.SetBool("Walk", true);
            up = false;

            gameController();

        }
        if (Input.GetKeyUp(KeyCode.W))
        {
            up = true;

        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            gameController();
            animator.SetBool("Walk", true);
            down = false;

        }


        if (Input.GetKeyUp(KeyCode.S))
        {
            down = true;
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            gameController();
            animator.SetBool("Walk", true);
            left = false;

        }


        if (Input.GetKeyUp(KeyCode.A))
        {
            left = true;
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            gameController();
            animator.SetBool("Walk", true);
            right = false;

        }


        if (Input.GetKeyUp(KeyCode.D))
        {
            right = true;
        }

        if (up && down && left && right)
        {
            animator.SetBool("Walk", false);
        }
        if (Input.GetKeyDown(KeyCode.LeftShift)&&Input.GetKeyDown(KeyCode.W))
        {
            animator.SetBool("Run", true);
        }
        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            animator.SetBool("Run", false);
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





   