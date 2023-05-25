using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class SistemaPesca : MonoBehaviour
{
    public Animator animator;
    public GameObject[] fishPrefabs;
    public Transform fishingRod;

    public TMPro.TextMeshProUGUI coinsText;
    public int coinsPerFish = 10;

    private int coins = 0;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            StartFishing();
        }
    }

    private void StartFishing()
    {
        // Obtener un índice aleatorio para seleccionar un pez del array
        int randomFishIndex = Random.Range(0, fishPrefabs.Length);

        // Instanciar un objeto de pez y anclarlo a la caña de pescar
        GameObject fish = Instantiate(fishPrefabs[randomFishIndex], fishingRod);
        fish.transform.localPosition = Vector3.zero;

        // Iniciar la animación de pesca
        animator.SetTrigger("Fishing");
    }

    public void CaptureFish()
    {
        // Ejecutar la animación de pesca en reversa
        animator.SetTrigger("ReelIn");

        // Obtener el pez anclado a la caña de pescar
        GameObject fish = fishingRod.GetChild(0).gameObject;

        // Destruir el pez después de 2 segundos
        Destroy(fish, 2f);

        // Sumar monedas y actualizar la UI
        coins += coinsPerFish;
        coinsText.text = "Coins: " + coins.ToString();
    }
}
