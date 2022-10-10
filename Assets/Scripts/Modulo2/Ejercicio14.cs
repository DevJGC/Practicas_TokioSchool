using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio14 : MonoBehaviour
{
    private float a = 1.4f;
    private float b = 2.1f;
    private float c = 3.6f;
    private float d = 4.8f;
    private float e = 5.3f;
    private float mediaAritmetica;



    void Start()
    {

        mediaAritmetica = (a + b + c + d + e) / 5;
        Debug.Log(mediaAritmetica);


    }


    void Update()
    {
       
    }
}
