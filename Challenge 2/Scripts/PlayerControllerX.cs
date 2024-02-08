using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;

    private float contador = 0;

    private float esperarParaNuevoDisparo = 1;
    // Update is called once per frame
    void Update()
    {



        contador += Time.deltaTime;

        if (contador >= esperarParaNuevoDisparo)
        {
            // On spacebar press, send dog
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);

                contador = 0;
                esperarParaNuevoDisparo = Random.Range(1, 3);


            }

        }
            
           
            
            
            
    
    
    
        }
       
}
