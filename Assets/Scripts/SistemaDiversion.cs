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
        // Disminuir la diversión gradualmente con el tiempo
        diversionActual -= decrementoDiversionPorSegundo * Time.deltaTime;

        // Asegurarse de que la diversión no sea menor que cero
        diversionActual = Mathf.Max(diversionActual, 0f);

        // Actualizar la imagen de fill amount en la interfaz de usuario
        float fillAmount = diversionActual / diversionMaxima;
        barraDiversion.fillAmount = fillAmount;

        // Comprobar si la diversión está por debajo del umbral
        if (diversionActual < 30f)
        {
            // Ejecutar acciones cuando la diversión está baja
        }
    }

    public void AumentarDiversion(float cantidad)
    {
        // Incrementar el nivel de diversión
        diversionActual += cantidad;

        // Asegurarse de que la diversión no exceda el máximo
        diversionActual = Mathf.Min(diversionActual, diversionMaxima);
    }
}
