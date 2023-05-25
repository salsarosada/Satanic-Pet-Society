using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SistemaDiversion : MonoBehaviour
{
    public static SistemaDiversion instancia;

    public Image barraDiversion;
    public float diversionMaxima = 100f;
    public float decrementoDiversionPorSegundo = 1f;

    private float diversionActual;

    private void Awake()
    {
        if (instancia == null)
            instancia = this;
        else
            Destroy(gameObject);
    }

    private void Start()
    {
        diversionActual = diversionMaxima;
    }

    private void Update()
    {
        // Disminuir la diversi�n gradualmente con el tiempo
        diversionActual -= decrementoDiversionPorSegundo * Time.deltaTime;

        // Asegurarse de que la diversi�n no sea menor que cero
        diversionActual = Mathf.Max(diversionActual, 0f);

        // Actualizar la imagen de fill amount en la interfaz de usuario
        float fillAmount = diversionActual / diversionMaxima;
        barraDiversion.fillAmount = fillAmount;

        // Comprobar si la diversi�n est� por debajo del umbral
        if (diversionActual < 30f)
        {
            // Ejecutar acciones cuando la diversi�n est� baja
        }
    }

    public void AumentarDiversion(float cantidad)
    {
        // Incrementar el nivel de diversi�n
        diversionActual += cantidad;

        // Asegurarse de que la diversi�n no exceda el m�ximo
        diversionActual = Mathf.Min(diversionActual, diversionMaxima);
    }
}
