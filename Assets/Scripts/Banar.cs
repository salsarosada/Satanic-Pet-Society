using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Banar : MonoBehaviour
{
    public SistemaLimpieza sistemaLimpieza;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Verificar si se ha arrastrado un sprite de comida sobre la mascota
        if (collision.gameObject.CompareTag("Esponja"))
        {
            // Alimentar a la mascota
            sistemaLimpieza.AumentarLimpieza(1f);
        }
    }
}
