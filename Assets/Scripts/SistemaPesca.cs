using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SistemaPesca : MonoBehaviour
{
    public Animator animator;
    public GameObject[] fishPrefabs;
    public Transform fishingRod;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            StartFishing();
        }
    }

    private void StartFishing()
    {
        // Obtener un �ndice aleatorio para seleccionar un pez del array
        int randomFishIndex = Random.Range(0, fishPrefabs.Length);

        // Instanciar un objeto de pez y anclarlo a la ca�a de pescar
        GameObject fish = Instantiate(fishPrefabs[randomFishIndex], fishingRod);
        fish.transform.localPosition = Vector3.zero;

        // Iniciar la animaci�n de pesca
        animator.SetTrigger("Fishing");
    }

    public void CaptureFish()
    {
        // Ejecutar la animaci�n de pesca en reversa
        animator.SetTrigger("ReelIn");

        // Obtener el pez anclado a la ca�a de pescar
        GameObject fish = fishingRod.GetChild(0).gameObject;

        // Destruir el pez despu�s de 2 segundos
        Destroy(fish, 2f);
    }
}
