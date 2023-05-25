using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeguirPersonaje : MonoBehaviour
{
    public Transform personaje;
    public Vector3 offset;

    private void LateUpdate()
    {
        // Actualizar la posici�n de la c�mara seg�n la posici�n del personaje
        transform.position = personaje.position + offset;
    }
}
