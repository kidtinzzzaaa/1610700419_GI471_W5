using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class W5_PlayerMovement : MonoBehaviour
{
    public float speedMove;
    public float jumpPower;
    public float gravity = 20.0f;


    private CharacterController charaterController;
    private float inputHorizontal;
    private float inputVertical;
    private bool inputJump;
    private Vector3 velocity;


    void Start()
    {
        charaterController = this.GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        UpdateMovement();
    }
    public void SetInput_Horizontal(float axis)
    {
        inputHorizontal = axis;
    }

    public void SetInput_Vertical(float axis)
    {
        inputVertical = axis;
    }

    public void UpdateMovement()
    {
        if (charaterController.isGrounded)
        {
            velocity = Vector3.zero;
            Vector3 dirVertical = this.transform.forward * inputVertical;
            Vector3 dirHorizontal = this.transform.right * inputHorizontal;

            velocity = (dirVertical + dirHorizontal).normalized;
            velocity *= speedMove;

            if (inputJump)
            {
                velocity.y += jumpPower;
            }
        }
        velocity.y -= gravity * Time.deltaTime;

        charaterController.Move(velocity * Time.deltaTime);
    }
    public void setInput_jump(bool toSet)
    {
        inputJump = toSet;
    }
}

