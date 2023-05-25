using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Juguete : MonoBehaviour
{
    private bool isBeingDragged = false;
    private Vector3 offset;
    private float timer = 0f;
    private float delay = 0.1f; // Tiempo de espera entre incrementos de diversión
    private float increment = 1f; // Incremento de diversión en cada intervalo

    private void OnMouseDown()
    {
        // Calcular el desplazamiento entre la posición del mouse y la posición del objeto del juguete
        offset = transform.position - Camera.main.ScreenToWorldPoint(Input.mousePosition);
        isBeingDragged = true;
    }

    private void OnMouseDrag()
    {
        if (isBeingDragged)
        {
            // Actualizar la posición del objeto del juguete según la posición del mouse
            Vector3 newPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition) + offset;
            transform.position = new Vector3(newPosition.x, newPosition.y, transform.position.z);

            // Incrementar el temporizador
            timer += Time.deltaTime;

            // Verificar si ha pasado el tiempo suficiente para aumentar la diversión
            if (timer >= delay)
            {
                // Aumentar la diversión gradualmente
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
