using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ArrastrarComida : MonoBehaviour
{
    private bool isDragging = false;
    private Vector3 initialPosition;

    private void OnMouseDown()
    {
        isDragging = true;
        initialPosition = transform.position;
        MovimientoPersonaje.singleton.bloqueo = true;
    }

    private void OnMouseDrag()
    {
        if (isDragging)
        {
            Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            transform.position = new Vector3(mousePosition.x, mousePosition.y, 0f);
        }
    }

    private void OnMouseUp()
    {
        if (isDragging)
        {
            isDragging = false;
            MovimientoPersonaje.singleton.bloqueo = false;
            // Aqu� puedes agregar tu l�gica para soltar el sprite, por ejemplo,
            // verificar si el sprite est� sobre alg�n objeto espec�fico y realizar una acci�n.

            // Si deseas volver a la posici�n inicial al soltar el sprite, puedes descomentar la l�nea siguiente:
            // transform.position = initialPosition;
        }
    }
}
