using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestBoletin5_3 : MonoBehaviour
{
   // Ejercicio 3
     GameObject objeto;

    void Awake()
    {
       
        // objeto = GameObject.Find("Cube"); - Busca el objeto por Nombre
        objeto = GameObject.FindWithTag("Player"); // Busca el objeto por Tag
        Debug.Log(objeto);
    }

 
    void Start()
    {
        
    }



    
    void Update()
    {
        
    }
}
