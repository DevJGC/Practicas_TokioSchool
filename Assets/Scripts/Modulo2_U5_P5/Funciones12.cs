using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Funciones12 : MonoBehaviour
{

    float height = 5;
    float width = 6;
    float hypotenuse=0;

    float resultado;


    
    void Start()
    {

        calcHypotenuse(height, width, hypotenuse);
        Debug.Log(resultado);




    }


    float calcHypotenuse(float a, float b, float h)
    {

        if (h == 0)
        {
            float a_square = Mathf.Pow(a, 2);
            float b_square = Mathf.Pow(b, 2);
            resultado = Mathf.Sqrt(a_square + b_square);
        }




        return resultado;


    }

}
