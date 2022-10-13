using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Funciones6 : MonoBehaviour
{

    public int[] numberArray = { 7, 5, 6 };
    public int b = 3;
    public bool resultado = true;


    void Start()
    {

        for (int n = 0; n < numberArray.Length; n++)

            {
                Calculo(numberArray[n], b);  // revisa en cada indice del array
                Debug.Log( numberArray[n] + " ¿es divisible por " + b + "? por lo que es " + resultado);
                resultado = true; // restaura a true para revisar el siguiente calculo del array
            }
    }   


    void Update()
    {

    }

    public bool Calculo(int a, int b)
    {
        int total;

        total = a % b; // saca el resto

        if (total != 0)  // si es distintos de 0, es que no es divisible, por el contrario sigue como True.
             {
                resultado = false;
             }

       // Debug.Log("Resto " + total);

        return resultado;
    }

}

