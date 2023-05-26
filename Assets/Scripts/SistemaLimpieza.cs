using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SistemaLimpieza : MonoBehaviour
{
    public Image limpiezaBar;
    public float nivelLimpiezaMaximo = 100f;
    public float nivelLimpiezaMinimo = 30f;
    public float velocidadDecrementoLimpieza = 1f;

    private float nivelLimpiezaActual;

    private void Start()
    {
        nivelLimpiezaActual = nivelLimpiezaMaximo;
        //nivelLimpiezaActual = PlayerPrefs.GetInt("Limpieza");
    }

    private void Update()
    {
        // Disminuir gradualmente el nivel de limpieza con el tiempo
        nivelLimpiezaActual -= velocidadDecrementoLimpieza * Time.deltaTime;

        // Actualizar la barra de limpieza
        float fillAmount = nivelLimpiezaActual / nivelLimpiezaMaximo;
        limpiezaBar.fillAmount = fillAmount;

        //PlayerPrefs.SetInt("Limpieza", Mathf.RoundToInt(nivelLimpiezaActual));

        // Verificar si el nivel de limpieza está por debajo del mínimo
        if (nivelLimpiezaActual < nivelLimpiezaMinimo)
        {
            // Cambiar el sprite a uno sucio
            // Puedes utilizar un componente SpriteRenderer en el objeto de la mascota
            // y asignarle el sprite sucio adecuado
            // Ejemplo: GetComponent<SpriteRenderer>().sprite = spriteSucio;
        }
    }
}
