using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu : MonoBehaviour
{
    public GameObject creditos;
    /*public void Inicio()
    {
        SceneManager.LoadScene("SampleScene");
    }*/

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
