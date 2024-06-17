using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Key
{
    None = -1,
    Left,
    Right,
    Up,
    Down,
    Max
}

public static class InputKeyManager
{
    static Dictionary<Key, KeyCode> keys = new Dictionary<Key, KeyCode>();

    static InputKeyManager()
    {
        //모든 키 초기화
        //todo: 데이터 베이스를 이용해 초기화
        keys.Add(Key.Left, KeyCode.A);
        keys.Add(Key.Right, KeyCode.D);
        keys.Add(Key.Up, KeyCode.W);
        keys.Add(Key.Down, KeyCode.S);
    }

    public static bool GetKey(Key key)
    {
        if (keys.TryGetValue(key, out KeyCode outKeyCode))
        {
            return Input.GetKey(outKeyCode);
        }

        return false;
    }

    public static bool GetKeyDown(Key key)
    {
        if (keys.TryGetValue(key, out KeyCode outKeyCode))
        {
            return Input.GetKeyDown(outKeyCode);
        }

        return false;
    }
}
