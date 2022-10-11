using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio15 : MonoBehaviour
{
    public float a;
    public float b;
    public float c;
    public float d;
    public float e;
    public float f;
    public float g;
    private float mediaAritmetica;
    public int numeroDeValores;
    



    void Start()
    {

        mediaAritmetica = (a + b + c + d + e + f + g) / numeroDeValores;
        Debug.Log(mediaAritmetica);


    }


    void Update()
    {

    }

}
