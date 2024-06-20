using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public static class PlayerInput
{
    static short keyInputFlag;
    
    public static float GetHorizontalKey()
    {
        if (InputKeyManager.GetKeyDown(Key.Right))
        {
            AddFlagToKeyFlag(Key.Right);
        }
        else if (InputKeyManager.GetKeyUp(Key.Right))
        {
            DeleteFlagToKeyFlag(Key.Right);
        }
        
        if (InputKeyManager.GetKeyDown(Key.Left))
        {
            AddFlagToKeyFlag(Key.Left);
        }
        else if (InputKeyManager.GetKeyUp(Key.Left))
        {
            DeleteFlagToKeyFlag(Key.Left);
        }

        return GetReturnValueForInput(Key.Right, Key.Left);
    }

    public static float GetVerticalKey()
    {
        if (InputKeyManager.GetKeyDown(Key.Up))
        {
            AddFlagToKeyFlag(Key.Up);
        }
        else if (InputKeyManager.GetKeyUp(Key.Up))
        {
            DeleteFlagToKeyFlag(Key.Up);
        }

        if (InputKeyManager.GetKeyDown(Key.Down))
        {
            AddFlagToKeyFlag(Key.Down);
        }
        else if (InputKeyManager.GetKeyUp(Key.Down))
        {
            DeleteFlagToKeyFlag(Key.Down);
        }

        return GetReturnValueForInput(Key.Up, Key.Down);
    }

    static float GetReturnValueForInput(Key positiveKey, Key negativeKey)
    {
        float value = 0f;
        bool isPositiveKeyDown = IsExistInKeyFlag(positiveKey);
        bool isNegativeKeyDown = IsExistInKeyFlag(negativeKey);
        
        if (isPositiveKeyDown && !isNegativeKeyDown)
        {
            value = 1f;
        }
        else if (!isPositiveKeyDown && isNegativeKeyDown)
        {
            value = -1f;
        }

        return value;
    }

    static void AddFlagToKeyFlag(Key key)
    {
        keyInputFlag |= (short)(1 << (int)key);
    }

    static void DeleteFlagToKeyFlag(Key key)
    {
        keyInputFlag ^= (short)(1 << (int)key);
    }

    static bool IsExistInKeyFlag(Key key)
    {
        var isExist = keyInputFlag & (short)(1 << (int)key);
        
        return isExist != 0;
    }
}
