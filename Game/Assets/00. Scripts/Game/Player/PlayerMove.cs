using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    [SerializeField]
    float speed;

    public void Move(Vector3 dir)
    {
        Vector3 nextDir = speed * Time.deltaTime * dir;
        transform.Translate(nextDir);
    }
}
