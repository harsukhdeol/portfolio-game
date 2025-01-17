﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
 
 public CharacterController controller;
 public Transform groundCheck;
 public float groundDistance = 4f;
 public LayerMask groundMask;
 bool isGrounded;
 public float speed = 12f;
 public float jumpHeight = 6.0f;

 public float gravity = -9.81f;

 Vector3 velocity; 
    void Update()
    {
        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);
        if(isGrounded && velocity.y<0){velocity.y = -2.0f;}

        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right*x + transform.forward*z;

        controller.Move(move*speed*Time.deltaTime);
        if(Input.GetButtonDown("Jump") &&isGrounded){
            velocity.y= Mathf.Sqrt(jumpHeight*-2.0f*gravity);
        }
        velocity.y +=gravity *Time.deltaTime;

        controller.Move(velocity*Time.deltaTime);
    }
}
