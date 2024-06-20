using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTest : MonoBehaviour
{
    public void TestHorizontalMovement()
    {
        transform.Translate(0.1f * new Vector3(PlayerInput.GetHorizontalKey(), 0f, 0f));
    }

    public void TestVerticalMovement()
    {
        transform.Translate(0.1f * new Vector3(0f, PlayerInput.GetVerticalKey(), 0f));
    }
}
