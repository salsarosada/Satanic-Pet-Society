using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public GameObject creditos;
    public GameObject panelInicio;

    public void Inicio()
    {
        panelInicio.SetActive(true);        
    }

    public void Nueva()
    {
        PlayerPrefs.DeleteAll();
        SceneManager.LoadScene("Personaje");
    }

    public void Cargar()
    {
        SceneManager.LoadScene("Inicio");
    }

    public void Creditos()
    {
        creditos.SetActive(true);
    }

    public void Volver()
    {
        creditos.SetActive(false);
    }

    public void Salir()
    {
        Application.Quit();
    }
}
