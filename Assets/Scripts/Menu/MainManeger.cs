using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainManeger : MonoBehaviour
{
   public static MainManeger Instance;

    public void Awake()
    {
       if(Instance != null)
        {
            Destroy(gameObject);
            return;
        }
        Instance = this;
        DontDestroyOnLoad(gameObject);
    }
}
