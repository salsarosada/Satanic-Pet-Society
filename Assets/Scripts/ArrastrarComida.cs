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
            // Aquí puedes agregar tu lógica para soltar el sprite, por ejemplo,
            // verificar si el sprite está sobre algún objeto específico y realizar una acción.

            // Si deseas volver a la posición inicial al soltar el sprite, puedes descomentar la línea siguiente:
            // transform.position = initialPosition;
        }
    }
}
