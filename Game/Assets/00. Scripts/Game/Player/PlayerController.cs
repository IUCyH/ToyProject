using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //For Running Test Codes
    [SerializeField]
    PlayerTest playerTest;

    [SerializeField]
    PlayerMove playerMove;
    
    void Update()
    {
        float x = PlayerInput.GetHorizontalKey();
        float y = PlayerInput.GetVerticalKey();
        Vector3 dir = new Vector3(x, y, 0f);
        
        playerMove.Move(dir);
    }
}
