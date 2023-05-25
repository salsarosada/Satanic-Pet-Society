using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Juguete : MonoBehaviour
{
    private bool isBeingDragged = false;
    private Vector3 offset;
    private float timer = 0f;
    private float delay = 0.1f; // Tiempo de espera entre incrementos de diversi�n
    private float increment = 1f; // Incremento de diversi�n en cada intervalo

    private void OnMouseDown()
    {
        // Calcular el desplazamiento entre la posici�n del mouse y la posici�n del objeto del juguete
        offset = transform.position - Camera.main.ScreenToWorldPoint(Input.mousePosition);
        isBeingDragged = true;
    }

    private void OnMouseDrag()
    {
        if (isBeingDragged)
        {
            // Actualizar la posici�n del objeto del juguete seg�n la posici�n del mouse
            Vector3 newPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition) + offset;
            transform.position = new Vector3(newPosition.x, newPosition.y, transform.position.z);

            // Incrementar el temporizador
            timer += Time.deltaTime;

            // Verificar si ha pasado el tiempo suficiente para aumentar la diversi�n
            if (timer >= delay)
            {
                // Aumentar la diversi�n gradualmente
                SistemaDiversion.instancia.AumentarDiversion(increment);

                // Reiniciar el temporizador
                timer = 0f;
            }
        }
    }

    private void OnMouseUp()
    {
        isBeingDragged = false;
    }
}
