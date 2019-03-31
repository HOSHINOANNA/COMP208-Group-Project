using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class keyboard : MonoBehaviour
{
    // Start is called before the first frame update
    private int State;
    private int oldState = 0;
    private int UP = 0;
    private int RIGHT = 1;
    private int DOWN = 2;
    private int LEFT = 3;
    private int RUN = 4;


    public float speed = 2.5f;

    void Start()
    {
    }
    void Update()
    {
        
        if (Input.GetKey(KeyCode.W))
        {
            setState(UP);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            setState(DOWN);
        }

        if (Input.GetKey(KeyCode.A))
        {
            setState(LEFT);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            setState(RIGHT);
        }


        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            speed = 4f;
            
        }

        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            speed = 2.5f;

        }
    }


    void setState(int currState)
    {
        Vector3 transformValue = new Vector3();
        int rotateValue = (currState - State) * 90;

        switch (currState)
        {
            case 0:
                transformValue = Vector3.forward * Time.deltaTime * speed;
              
               break;
            case 1:
                transformValue = Vector3.right * Time.deltaTime * speed;
               
                break;
            case 2:
                transformValue = Vector3.back * Time.deltaTime * speed;
            
                break;
            case 3:
                transformValue = Vector3.left * Time.deltaTime * speed;
              
                break;
        }

        transform.Rotate(Vector3.up, rotateValue);
        transform.Translate(transformValue, Space.World);
        oldState = State;
        State = currState;

    }
}
