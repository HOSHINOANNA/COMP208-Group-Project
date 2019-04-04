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
    private bool die = false;
    

    CharacterAttribute characterAttribute = new CharacterAttribute();


    
    void Start()
    {

        animator = this.GetComponent<Animator>();
      
    }


    void FixedUpdate()
    {
    
            if (Input.GetKeyDown(KeyCode.LeftShift))
            {
                if (Input.GetKeyDown(KeyCode.A))
                {
                    animator.SetBool("Run", true);
                }
            }
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
           

            if (up && down && left && right)
            {
                animator.SetBool("Walk", false);
            }
            if (Input.GetKeyDown(KeyCode.LeftShift) && Input.GetKeyDown(KeyCode.W))
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
        if (Input.GetMouseButtonDown(0))
        {
            animator.SetBool("Atk2", true);
        }
        if (Input.GetMouseButtonUp(0))
        {
            animator.SetBool("Atk2", false);
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





   