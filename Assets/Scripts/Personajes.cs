using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Personajes : MonoBehaviour
{
    public GameObject[] personajes;
    private int indice;
    void Start()
    {
        indice = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Siguiente()
    {
        if (indice < personajes.Length-1) {
            personajes[indice].SetActive(false);
            indice++;
            personajes[indice].SetActive(true);
        }
        else
        {
            personajes[indice].SetActive(false);
            indice = 0;
            personajes[indice].SetActive(true);
        }
        
    }

    public void Anterior()
    {
        if (indice > 0)
        {
            personajes[indice].SetActive(false);
            indice--;
            personajes[indice].SetActive(true);
        }
        else
        {
            personajes[indice].SetActive(false);
            indice = 3;
            personajes[indice].SetActive(true);
        }
    }

    public void Guardar()
    {
        PlayerPrefs.SetInt("Personaje", indice);
        SceneManager.LoadScene("Inicio");

    }
}
