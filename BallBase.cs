using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallBase : MonoBehaviour
{
    public string Name = "Ball";
    public float Speed = 5f;
    public float AreaDetection = 2f;
    public Vector3 MousePosition;

    
    public virtual void Move()
    {
         if (Input.GetMouseButton(0))
         {
             //Accedemos a la posicion del mouse
             MousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
             MousePosition.z = 0f;
         }
         //Calculamos direcci�n
         Vector3 direction = (MousePosition - transform.position).normalized;

        //Mover al objeto a la direccion calculada
        transform.Translate(direction * Speed * Time.deltaTime);
    }
}
