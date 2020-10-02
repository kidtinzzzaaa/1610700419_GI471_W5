using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class W5_PlayerController : MonoBehaviour
{
    public W5_PlayerMovement playerMovement;

    private void Update()
    {
        playerMovement.SetInput_Horizontal(Input.GetAxis("Horizontal"));
        playerMovement.SetInput_Vertical(Input.GetAxis("Vertical"));
        //playerMovement.setInput_jump(Input.GetKeyDown("Space"));
    }
}
