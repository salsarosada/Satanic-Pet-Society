using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeguirPersonaje : MonoBehaviour
{
    public Transform personaje;
    public Vector3 offset;

    private void LateUpdate()
    {
        // Actualizar la posición de la cámara según la posición del personaje
        transform.position = personaje.position + offset;
    }
}
