using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Condicionales6 : MonoBehaviour
{
    public string name;
    public int age;

    void Start()
    {

        if (name == "Jose")
        {

            if (age == 51)
            {
                TestCondicionales1("Correcto");
            }
            else
            {
                TestCondicionales1("Incorrecto");
            }

        }

        else
        {
            TestCondicionales1("Incorrecto");
        }

    }


   


    void TestCondicionales1(string respuesta)

    {
        Debug.Log(respuesta);
    }
}
