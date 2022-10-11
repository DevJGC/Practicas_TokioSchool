using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio18 : MonoBehaviour
{

    // Hay muchos otros tipos de datos como : ushort uint long double etc.....


    private sbyte ochoBitsConSigno = 127; //De -128 a 127

    private byte ochoBitsSinSigno = 255; //De 0 a 255

    private char caracter = 'A'; //unicode (con comillas simples)
   



    void Start()
    {

        Debug.Log(ochoBitsConSigno);

        Debug.Log(ochoBitsSinSigno);

        Debug.Log(caracter);



    }

    
    void Update()
    {
        
    }
}
