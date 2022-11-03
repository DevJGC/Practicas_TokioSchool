using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GestionDeObjetos8 : MonoBehaviour
{
    // Ejercicio 8
    // Este Script está en la camara y referencia un Prefab llamado "cubo"
    [SerializeField] GameObject cubo;
    void Start()
    {
        // Instancia el primero objeto
        Instantiate(cubo, new Vector3(0,0,0), Quaternion.identity);
        StartCoroutine("InstanciarCubo");
    }

    IEnumerator InstanciarCubo()    
    {
        // Espera 2 segundos
        yield return new WaitForSeconds(2);
        // Instancia el segundo objeto
        Instantiate(cubo, new Vector3(0,0,2), Quaternion.identity);
        yield return new WaitForSeconds(2);
        // Instancia el tercer objeto
        Instantiate(cubo, new Vector3(0,0,4), Quaternion.identity);
        yield return new WaitForSeconds(2);
        // Instancia el cuarto objeto
        Instantiate(cubo, new Vector3(0,0,6), Quaternion.identity);
         yield return new WaitForSeconds(2);
        // Instancia el quinto objeto
        Instantiate(cubo, new Vector3(0,0,8), Quaternion.identity);    

        // Busca por nombre y asigna a un Array temporal para después borrarlos
        GameObject[] objectsInScene = FindObjectsOfType<GameObject>();
        foreach (GameObject obj in objectsInScene)
        {
            if (obj.name == "Cubo(Clone)")
            {
                Destroy(obj);
            }
        }
       
    }
}
