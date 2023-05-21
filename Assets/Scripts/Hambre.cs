using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Hambre : MonoBehaviour
{
    public Slider foodSlider; // Referencia al Slider de la barra de comida
    public float maxHunger = 100f; // Valor máximo de la barra de comida
    public float hungerDecreaseRate = 1f; // Tasa de disminución del hambre por segundo

    private float currentHunger; // Valor actual de la barra de comida

    private void Start()
    {
        currentHunger = maxHunger;
        UpdateFoodSlider();
    }

    private void Update()
    {
        DecreaseHungerOverTime();
    }

    private void DecreaseHungerOverTime()
    {
        currentHunger -= hungerDecreaseRate * Time.deltaTime;
        currentHunger = Mathf.Clamp(currentHunger, 0f, maxHunger);

        UpdateFoodSlider();
    }

    private void UpdateFoodSlider()
    {
        float targetValue = currentHunger / maxHunger;
        float currentValue = foodSlider.value;
        float newValue = Mathf.Lerp(currentValue, targetValue, Time.deltaTime * 5f); // Ajusta la velocidad de la interpolación modificando el factor 5f

        foodSlider.value = newValue;
    }
}
