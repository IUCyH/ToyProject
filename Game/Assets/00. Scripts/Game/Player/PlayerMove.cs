using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    [SerializeField]
    float walkSpeed;
    float speed;

    void Start()
    {
        speed = walkSpeed;
    }

    public void Move(Vector3 dir)
    {
        Vector3 nextDir = speed * Time.deltaTime * dir;
        transform.Translate(nextDir);
    }
}
