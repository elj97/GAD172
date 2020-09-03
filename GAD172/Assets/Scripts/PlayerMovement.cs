using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 0;
    private float gravity = 3;

    private CharacterController controller;

    private Vector3 moveDirection = Vector3.zero;
        
    private void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    private void Update()
    {
        if(controller.isGrounded)
        {
            float moveX = Input.GetAxis("Horizontal");
            float moveZ = Input.GetAxis("Vertical");

            moveDirection = new Vector3(moveX, 0, moveZ);
            moveDirection *= moveSpeed;

            
        }

        moveDirection.y -= gravity;

        controller.Move(moveDirection * Time.deltaTime);
    }

    
}
