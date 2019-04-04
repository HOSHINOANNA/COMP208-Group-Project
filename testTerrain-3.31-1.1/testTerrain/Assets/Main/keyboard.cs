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
    bool isRotating;
    float ver = 0;
    float hor = 0;
    public float turnspeed = 10;
    private float rotateSpeed = 2; //摄像机旋转速度
    public float speed = 2.5f;

 //   CharacterAttribute attribute = GameObject.Find("Kaoru_schooluniform").GetComponent<CharacterAttribute>();


    void Start()
    {
        
    }
    void Update()
    {
        CharacterAttribute attribute = GameObject.Find("Kaoru_schooluniform").GetComponent<CharacterAttribute>();

        CharacterAttribute characterAttribute = new CharacterAttribute();

        Debug.Log("Blood:"+attribute.getBlood());
        if (attribute.getBlood() > 0)
        {
            // RotateView();
            hor = Input.GetAxis("Horizontal");
            ver = Input.GetAxis("Vertical");

            if (hor != 0 || ver != 0)
            {
                //转身
                Rotating(hor, ver);



            }
            if (Input.GetKey(KeyCode.W))
            {
                if (Input.GetKeyDown(KeyCode.Space))
                {
                }
                else
                {

                    setState(UP);
                }
            }
            else if (Input.GetKey(KeyCode.S))
            {
                if (Input.GetKeyDown(KeyCode.Space)) { }
                else
                {
                    setState(DOWN);
                }

            }
            else if (Input.GetKey(KeyCode.LeftShift))
            {
                if (Input.GetKeyDown(KeyCode.Space)) { }
                else
                {
                    setState(UP);
                }
            }


            if (Input.GetKey(KeyCode.A))
            {
                if (Input.GetKey(KeyCode.Space)) { }
                else
                {
                    setState(LEFT);
                }
            }
            else if (Input.GetKey(KeyCode.D))
            {
                if (Input.GetKeyDown(KeyCode.Space)) { }
                else
                {
                    setState(RIGHT);
                }
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
            
        
    }


    void setState(int currState)
    {


            switch (currState)
            {
                case 0:
                    // transformValue = Vector3.forward * Time.deltaTime * speed;
                    this.transform.Translate(Vector3.forward * Time.deltaTime * speed);
                    break;
                case 1:
                    // transformValue = Vector3.right * Time.deltaTime * speed;
                    // this.transform.Translate(Vector3.right * Time.deltaTime * speed);
                    break;
                case 2:
                    //  transformValue = Vector3.back * Time.deltaTime * speed;
                    this.transform.Translate(Vector3.back * Time.deltaTime * -speed);
                    break;
                case 3:
                    //this.transform.Translate(Vector3.left * Time.deltaTime * speed);

                    break;
            } } 

        // transform.Rotate(Vector3.up, rotateValue);
        //transform.Translate(transformValue, Space.World);
        //oldState = State;
        //sState = currState;
        void Rotating(float hor, float ver)
        {
            //获取方向
            Vector3 dir = new Vector3(hor, 0, ver);
            //将方向转换为四元数
            Quaternion quaDir = Quaternion.LookRotation(dir, Vector3.up);
            //缓慢转动到目标点
            transform.rotation = Quaternion.Lerp(transform.rotation, quaDir, Time.fixedDeltaTime * turnspeed);

        }

        }


   



   
   

