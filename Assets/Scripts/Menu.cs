using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public GameObject creditos;

    public void Inicio()
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
