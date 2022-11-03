using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GestionDeObjetos9 : MonoBehaviour
{
    // Ejercicio 9
    [SerializeField] GameObject esfera;
    [SerializeField] GameObject referencia;
    public int contadorTotal=0;
    
    int directionX;
    int directionY;

    int direInicial;

    int velocity=10;

    // Contador
    [SerializeField] int contador;
    [SerializeField] float recordValue;

    void Start()
    {
        // Inicia la bola 
       directionStart();    

    }


    void Update()
    {
         // Mueve la bola
        transform.Translate((directionX)*Time.deltaTime*velocity,(directionY)*Time.deltaTime*velocity,0);

        // Suma el "Time.deltatime" en la variable "recordValue"
        recordValue += Time.deltaTime;
        // Convierte en entero el valor de tiempo y lo vuelca en el contador, creando un cronómetro. "contador" siempre será el entero más alto hasta el momento
        contador = (int)recordValue;
        // Cada 5 segundos
        if (contador == 5 && recordValue > 5)
        {
            contador = 0; 
            recordValue = 0; 
            Destroy(referencia);
            contadorTotal = contadorTotal + 2;
            referencia = Instantiate(esfera, new Vector3(0,0,0), Quaternion.identity); 
            referencia = Instantiate(esfera, new Vector3(0,0,0), Quaternion.identity); 

            if (contadorTotal >= 100)
            {
                Destroy(gameObject);
            }

        }   

    }


 void directionStart()    
    {
        // Inicia la bola en una direccion aleatoria
        direInicial=Random.Range(1,5);

        switch (direInicial)
        {
            case 1:
                directionX=1;
                directionY=1;
                break;
            case 2:
                directionX=-1;
                directionY=1;
                break;

            case 3:
                directionX=1;
                directionY=-1;
                break;

            case 4:
                directionX=-1;
                directionY=-1;
                break;
            
            default:
           // Debug.Log("No hay direccion!!");
            break;

        }  

    }

}
