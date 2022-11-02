using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GestionDeObjetos6 : MonoBehaviour
{
    // Ejercicio 6 - Pre Ping Pong

    int directionX;
    int directionY;

    int direInicial;

    int velocity=10;



    void Start()
    {
       directionStar();        
       
    }

    
    void Update()
    {
        transform.Translate((directionX)*Time.deltaTime*velocity,(directionY)*Time.deltaTime*velocity,0);
          
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Left-Right")
        {
            Debug.Log("Hay colision con pared");
            directionX = directionX * -1;

        }

        if (collision.gameObject.tag == "Up-Down")
        {
            Debug.Log("Hay colision con techo");
            directionY = directionY * -1;
        }
   
    }



    void directionStar()    
    {
        
        direInicial=Random.Range(1,5);

        Debug.Log(direInicial);

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
            Debug.Log("No hay direccion!!");
            break;

        }  

    }
    
}


