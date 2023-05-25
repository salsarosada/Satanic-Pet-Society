using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Hambre : MonoBehaviour
{
    public float hambreInicial = 100f;
    public float velocidadHambre = 10f;
    public Image imagenHambre;

    private float hambreActual;

    private void Start()
    {
        hambreActual = hambreInicial;
    }

    private void Update()
    {
        // Actualizar el nivel de hambre
        hambreActual -= velocidadHambre * Time.deltaTime;

        // Asegurarse de que el nivel de hambre no sea menor que cero
        hambreActual = Mathf.Max(hambreActual, 0f);

        // Actualizar la imagen de hambre
        imagenHambre.fillAmount = hambreActual / hambreInicial;
    }

    public void AumentarHambre(float cantidad)
    {
        hambreActual += cantidad;
        hambreActual = Mathf.Clamp(hambreActual, 0f, hambreInicial);
        imagenHambre.fillAmount = hambreActual / hambreInicial;
    }
}
