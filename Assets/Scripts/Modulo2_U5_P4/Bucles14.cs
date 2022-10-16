using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bucles14 : MonoBehaviour
{
    // Ejercicio 14 -  Declaro variables e inicializo el Array y añado el otro Array desde el editor
    public string[] edificio1 = { "Paco", "Jose", "Manolo", "Pilar", "Juan", "Federico", "Antonio", "Jesus", "Maria", "Encarna", "Julia", "Pepita", "Pol","Aitana","Vera" };
    public string[] edificio2;
    
    // Contador del While
    int n;

    // Contador de bucle For
    int i;

    void Start()
    {
        // Se repite mientras n no sea la longitud del Array
        while (n < edificio1.Length) 
        
        {
            // Bucle que se repite hasta la longitud del Array
            for (i = 0; i < edificio1.Length; i++) 
            
            { 
                // Compara el valor de un Array sobre el índice del otro Array
                if (edificio1[n] == edificio2[i])

                {
                    // Muestra por consola cuando hay un valor del primer Array en algún índice del segundo Array
                    Debug.Log("Hay al menos dos nombres iguales, el nombre " + edificio1[n] + " está también en el otro edificio");               
                }

            }
        // Suma 1 a cada bucle While
        n++;

        }
    }

}
