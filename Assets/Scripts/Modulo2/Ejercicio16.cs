using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio16 : MonoBehaviour
{

    private int a = 0;
    private int b = 1;
    private int c;

    void Start()
    {
        
    }

  
    void Update()
    {

        c = a;

        a = b;

        b = c + a;

        Debug.Log(a);

        


    }
}
