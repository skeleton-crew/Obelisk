using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Singleton<T> : MonoBehaviour where T : MonoBehaviour
{
    public static T Instance { get; private set; }
    
    private void Awake()
    {
        if(Instance!=null)
        {
            Destroy(this);
            return;
        }
        Instance = this as T;
        DontDestroyOnLoad(gameObject);

}
}
