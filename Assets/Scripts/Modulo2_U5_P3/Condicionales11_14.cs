using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Condicionales11_14 : MonoBehaviour
{
    public int contador;
    [SerializeField] int multiplo = 250; // Ejercicio 12
    public GameObject cubo; // Ejercicio 13
    public float x = 1; // Ejercicio 13
    public float y = 1; // Ejercicio 13
    public float z = 1; // Ejercicio 13
    public bool activate = true;

    void Start()
    {
        
    }

   
    void Update()
    {
        contador++;
        
        multiplo = contador % 250; // Ejercicio 12
        //  if (contador == 50 || contador == 500 || contador == 5000)  // Ejercicio 11

        if (multiplo == 0)  // Ejercicio 12 y 14
        {
            // cubo.transform.localScale += new Vector3(0.1f, 0.1f, 0.1f); // Ejercicio 13 Aumenta la escala en un 10%
            // Debug.Log(contador); // Ejercicio 11 y 12
            if (activate == true) 
            {
                cubo.SetActive(false); // Ejercicio 14 activa y desactiva el cubo cada coincidencia
                activate = false;
            }

            else
            {
                cubo.SetActive(true); // Ejercicio 14 activa y desactiva el cubo cada coincidencia
                activate = true;
            }
                
              


        }
    }

       




    
}
