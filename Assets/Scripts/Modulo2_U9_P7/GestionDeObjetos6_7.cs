using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GestionDeObjetos6_7 : MonoBehaviour
{
    // Ejercicio 6 y 7 - Pre Ping Pong
    //[SerializeField] GameObject ball;

    int directionX;
    int directionY;

    int direInicial;

    int velocity=10;
    [SerializeField] int lifes=10;



    void Start()
    {
       // Inicia la bola 
       directionStart();        
       
    }

    
    void Update()
    {
        // Mueve la bola
        transform.Translate((directionX)*Time.deltaTime*velocity,(directionY)*Time.deltaTime*velocity,0);
          
    }

    // Detecta colisiones con paredes o techo/suelo - Resta una vida en cada choque y resetea a los 10
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Left-Right")
        {
            //Debug.Log("Hay colision con pared");
            // Invierte direccion en X
            directionX = directionX * -1;

        }

        if (collision.gameObject.tag == "Up-Down")
        {
            //Debug.Log("Hay colision con techo");
            // Invierte direccion en Y
            directionY = directionY * -1;
        }

        // Resta una vida y si llega a 0 resetea
        lifes--;
        if(lifes==0)
        {
            directionStart();          
        }
   
    }


    // Inicia la bola en una direccion aleatoria y mira si no tiene vida, en cuyo caso resetea
    void directionStart()    
    {
        if (lifes==0)
        {
            transform.position = new Vector3(0,0,0);
            lifes=10;
        }

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


