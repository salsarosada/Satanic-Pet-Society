using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Personajes : MonoBehaviour
{
    public GameObject[] personajes;
    private int indice;
    public TMP_Text nombre;

    public SeguirPersonaje camaraScript;

    void Start()
    {
        indice = 0;
    }

    // Update is called once per frame
    void Update()
    {
        nombre.text = personajes[indice].gameObject.name;
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
        camaraScript.personaje = personajes[indice].transform;
    }
}
