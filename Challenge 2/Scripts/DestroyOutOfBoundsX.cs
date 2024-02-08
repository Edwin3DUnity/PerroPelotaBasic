using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBoundsX : MonoBehaviour
{
   [SerializeField, Range(-60,50), Tooltip("limite izquierdo")]  private float leftLimit = -30;
    [ SerializeField, Range(-1,-15), Tooltip("limite hacia abajo ")]  float bottomLimit = -5;

    // Update is called once per frame
    void Update()
    {
        // Destroy dogs if x position less than left limit
        if (transform.position.x < leftLimit)
        {
            Destroy(gameObject);
            Debug.Log("Eliminado objeto" + gameObject.name);
        } 
        // Destroy balls if y position is less than bottomLimit
      else if (transform.position.y < bottomLimit)
        {
            Destroy(gameObject);
            //Time.timeScale = 0.1f;
            Debug.Log("Game Over");
        }

    }
}
