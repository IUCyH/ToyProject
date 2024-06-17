using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Singleton_DontDestroy<T> : MonoBehaviour where T : Singleton_DontDestroy<T>
{
    public static T Instance { get; private set; }
    
    protected virtual void OnAwake(){}
    protected virtual void OnStart(){}
    
    void Awake()
    {
        if (ReferenceEquals(Instance, null))
        {
            Instance = (T)this;
            OnAwake();
            
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(this);
        }
    }

    void Start()
    {
        if (!ReferenceEquals(Instance, null))
        {
            OnStart();
        }
    }
}
