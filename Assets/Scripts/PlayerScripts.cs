using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScripts : MonoBehaviour
{
    Rigidbody2D myBody;
    [SerializeField] float tourqeAmout=1f;
    SurfaceEffector2D surfaceEffector2D;
    [SerializeField] float boostSpeed = 15f;
    [SerializeField] float baseSpeed=5f;


    bool canMove=true;
    bool canRotate = true;

    // Start is called before the first frame update
    void Start()
    {
        myBody=GetComponent<Rigidbody2D>();
        surfaceEffector2D = FindObjectOfType<SurfaceEffector2D>();
    }

    // Update is called once per frame
    void Update()
    {
        RotatePlayer();
        RespondToBoost();

    }


    public void DisableControll()
    {
        canMove = false;
        canRotate = false;

    }




     void RespondToBoost()
    {
        if (canMove)
        {
            if (Input.GetKey(KeyCode.UpArrow))
            {
                surfaceEffector2D.speed = boostSpeed;
            }
            else
            {
                surfaceEffector2D.speed = baseSpeed;
            }

        }

    }

    void RotatePlayer()
    {
        if (canRotate)
        {
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                myBody.AddTorque(tourqeAmout);

            }
            else if (Input.GetKey(KeyCode.RightArrow))
            {
                myBody.AddTorque(-tourqeAmout);

            }

        }
      
    }

    



}//class



























































