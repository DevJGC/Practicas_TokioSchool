using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bucles15 : MonoBehaviour
{
    // Ejercicio 15 - Creo variable p�blica para poner valor desde el editor
    public int wheels;

    // Revisa el valor de "wheels" y si encuentra coincidencia con el "case" muestra mensaje. Si no hay coincidencias, muestra el "Default"
    void Start()
    {
        switch (wheels)
        {
            case 1:

                Debug.Log("El veh�culo es un monociclo");

                break;

            case 2:

                Debug.Log("El veh�culo es una moto");

                break;

            case 3:

                Debug.Log("El veh�culo es un triciclo");

                break;

            case 4:

                Debug.Log("El veh�culo es un coche");

                break;

            default:

                Debug.Log("No tienes un veh�culo o no tenemos informaci�n del mismo");

                break;

        }

    }

}
