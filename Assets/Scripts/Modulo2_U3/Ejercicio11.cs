using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio11 : MonoBehaviour
{

    private float valor1 = 10f;
    private float valor2 = 20f;
    private float valor3 = 30f;
    private float sumaTotal;


    void Start()
    {


        sumaTotal = valor1;
        Debug.Log(sumaTotal);

        sumaTotal = valor1 + valor2;
        Debug.Log(sumaTotal);

        sumaTotal = valor1 + valor2 + valor3;
        Debug.Log(sumaTotal);


    }


    void Update()
    {
        
    }
}
