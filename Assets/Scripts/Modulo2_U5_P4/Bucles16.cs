using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bucles16 : MonoBehaviour
{
    // Ejercicio 16 - Creo una variable para ver en el editor
    public int showNumber;

    // Cuando coincide con cada valor "case", suma 1 a la variable, cuando sobrepasa el último valor, vuelve a 0 en el "default"
    void Update()
    {
        switch (showNumber)            
        {
            case 0:

                showNumber++;

                break;

            case 1:

                showNumber++;

                break;

            case 2:

                showNumber++;

                break;

            case 3:

                showNumber++;

                break;

            case 4:

                showNumber++;

                break;

            case 5:

                showNumber++;

                break;

            case 6:

                showNumber++;

                break;

            case 7:

                showNumber++;

                break;

            case 8:

                showNumber++;

                break;

            case 9:

                showNumber++;

                break;

            case 10:

                showNumber++;

                break;

            default:

                showNumber = 0;

                break;

        }

    }
}
