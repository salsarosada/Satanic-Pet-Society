using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Barra : MonoBehaviour
{
    public Image barra;
    public Sprite mesa;
    public Sprite cocina;
    public Sprite bano;
    public GameObject menuPausa;
    public GameObject botonPausa;

    public void Mesa()
    {
        barra.sprite = mesa;
    }

    public void Cocina()
    {
        barra.sprite = cocina;
    }

    public void Bano()
    {
        barra.sprite = bano;
    }

    public void Pausa()
    {
        Time.timeScale = 0f;
        botonPausa.SetActive(false);
        menuPausa.SetActive(true);
    }

    public void Reanudar()
    {
        Time.timeScale = 1f;
        botonPausa.SetActive(true);
        menuPausa.SetActive(false);
    }

    public void Salir()
    {
        Application.Quit();
    }

    public void Menu()
    {
        SceneManager.LoadScene("Menu");
    }
}
