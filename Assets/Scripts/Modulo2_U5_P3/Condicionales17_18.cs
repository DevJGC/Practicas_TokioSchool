using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Condicionales17_18 : MonoBehaviour
{
    // Ejercicio 18 Si se quita llave {} a un condicional, el código no marca error

    [SerializeField]
    string[] productos = { "huevos", "pan", "leche" };

    [SerializeField]
    string tipoDeTienda = "Tienda de lácteos";



    void Start()
    {
        
       if ((tipoDeTienda == "Tienda de lácteos") && (productos[0]=="leche" || productos[1]=="leche" || productos [2]=="leche"))
        {
            Debug.Log("Productos de tienda encajan con su nombre");
        }

       if ((tipoDeTienda == "Tienda de huevos") && (productos[0] == "huevos" || productos[1] == "huevos" || productos[2] == "huevos"))
        {
            Debug.Log("Productos de tienda encajan con su nombre");
        }



    }


    void Update()
    {

    }
}
