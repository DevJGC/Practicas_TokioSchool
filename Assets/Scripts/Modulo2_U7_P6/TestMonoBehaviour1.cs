using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestMonoBehaviour1 : MonoBehaviour
{
    // Ejercicio 8 - Primero se ejecuta el "Awake", después el "OnEnable" y por último el "Start"
    // Ejercicio 9 - Al activar y desactivar el objeto que lleva el Script, aparece el mensaje de "OnEnable" lo que quiere decir que esta función se ejecuta cada vez que se activa el objeto
    // Ejercicio 10 - Al desactivar el objeto se ejecuta la función "OnDisable" y al destruirlo desde la jerarquía, el "OnDestroy"      
    void Start()
    {
        Debug.Log("Hola soy la función Start");

    }

    void Awake()
    {
        Debug.Log("Hola soy la función Awake");
    
    }

    void OnEnable()
    {
        Debug.Log("Hola soy la función OnEnable");

    }

    void OnDisable()
    {   
        Debug.Log("Hola soy la función OnDisable");
        
    }

    void OnDestroy()
    {
        Debug.Log("Hola soy la función OnDestroy");

    }
    
    void Update()
    {
        
    }
}
