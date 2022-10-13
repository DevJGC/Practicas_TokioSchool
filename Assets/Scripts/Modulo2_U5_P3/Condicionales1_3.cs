using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Condicionales1_3 : MonoBehaviour
{

    public string name;


    void Start()
    {

        // Ejercicio 1 y 2
        //if (name == "Jose") // El nombre debe tener una coincidencia exacta

        //{
        //    TestCondicionales1();
        //}

    }

    
    void Update()
    {
        // Ejercicio 3 - Si se cambia el nombre desde el editor por otro distinto al indicado, no se ejecuta la función
        if (name == "Jose") // El nombre debe tener una coincidencia exacta

        {
            TestCondicionales1();
        }

    }


    void TestCondicionales1()

    {

     Debug.Log("Correcto");
    

    }
}
