using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bucles15 : MonoBehaviour
{
    // Ejercicio 15 - Creo variable pública para poner valor desde el editor
    public int wheels;

    // Revisa el valor de "wheels" y si encuentra coincidencia con el "case" muestra mensaje. Si no hay coincidencias, muestra el "Default"
    void Start()
    {
        switch (wheels)
        {
            case 1:

                Debug.Log("El vehículo es un monociclo");

                break;

            case 2:

                Debug.Log("El vehículo es una moto");

                break;

            case 3:

                Debug.Log("El vehículo es un triciclo");

                break;

            case 4:

                Debug.Log("El vehículo es un coche");

                break;

            default:

                Debug.Log("No tienes un vehículo o no tenemos información del mismo");

                break;

        }

    }

}
