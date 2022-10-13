using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Funciones1_3 : MonoBehaviour
{

    float number1 = 1;
    float number2 = 2;
    float number3 = 3;
    float number4 = 4;
    float number5 = 5;


    void Start()
    {


        // ShowText(); // Ejercicio 1 (Funciones)
        testSum();


    }

  
    void Update()
    {

        // ShowText("Jose"); // Ejercicio 2 (Funciones)

    }


    // public void ShowText(string myName) // Ejercicio 2 (Funciones)

    public void testSum()
    {
        float total;
        // Debug.Log("Hola, estoy aprendiendo programación"); // Ejercicio 1 (Funciones)

        // Debug.Log("Hola soy " + myName + ", y estoy aprendiendo programación"); Ejercicio 2 (Funciones)
        
        total = number1 + number2 + number3 + number4 + number5;
        Debug.Log("La suma de todos los elementos es " + total);

    }




}
