using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPool<T> where T : class
{
    Func<T> func;
    Queue<T> queue;
    int count;

    public ObjectPool(int generateCount, Func<T> generateFunc)
    {
        count = generateCount;
        func = generateFunc;

        Allocate();
    }

    void Allocate()
    {
        for (int i = 0; i < count; i++)
        {
            queue.Enqueue(func());
        }
    }

    public T Get()
    {
        if (queue.Count > 0)
        {
            return queue.Dequeue();
        }

        return func();
    }

    public void Set(T obj)
    {
        queue.Enqueue(obj);
    }
}
