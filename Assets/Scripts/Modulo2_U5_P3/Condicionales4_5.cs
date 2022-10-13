using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Condicionales4_5 : MonoBehaviour
{
    public string name;
    public int age;

    void Start()
    {

        if (name == "Jose" || age == 51) // Ejercicio 4 ( && AND cuando ambos sean iguales - Ejercicio 5 ( || OR cuando alguno sea igual)
        {
            TestCondicionales1("Correcto");
        }

        else
        {
          
         TestCondicionales1("Incorrecto");
           
        }

       
    }


    void Update()
    {
      
       

    }


    void TestCondicionales1(string respuesta)

    {

        Debug.Log(respuesta);

    }
}
