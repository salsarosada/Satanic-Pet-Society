using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlimentarMascota : MonoBehaviour
{
    public Hambre generadorHambre;
    private Animator animator;

    private void Awake()
    {
        animator = GetComponent<Animator>();
    }

    private IEnumerator ResetComerBool()
    {
        yield return new WaitForSeconds(1.5f);

        // Volver a poner el booleano "Comer" en falso
        animator.SetBool("Comer", false);
        animator.SetTrigger("Idle");
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Verificar si se ha arrastrado un sprite de comida sobre la mascota
        if (collision.gameObject.CompareTag("Comida"))
        {
            // Alimentar a la mascota
            generadorHambre.AumentarHambre(20f);

            // Destruir el objeto de comida
            Destroy(collision.gameObject);

            // Obtener el componente Animator de la mascota
            //Animator animator = GetComponent<Animator>();

            // Activar el trigger de la animación de comer
            animator.SetBool("Comer", true);

            StartCoroutine(ResetComerBool());
        }
    }
}
