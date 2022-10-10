using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio9 : MonoBehaviour
{

    public int a = 50;
    public int b = 20;
    public int c = 10; //este valor no se mantiene, se pierde en el Start

    void Start()
    {

        c = a + b; // C toma los datos de la suma de A + B

        // Aunque le hayamos asignado el valor a C desde el editor, mostrara el calculado aqui
        Debug.Log("Suma " + c);


    }


    void Update()
    {

    }
}
