using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class Barra : MonoBehaviour
{
    public Image barra;
    public Sprite mesa;
    public Sprite cocina;
    public Sprite bano;
    public GameObject menuPausa;
    public GameObject botonPausa;
    public GameObject cam;
    public float vel;
    public Animator animPanelBlanco;
    private int indicepersonaje;
    public GameObject[] personajes;
    public GameObject mapa;
    public int dinero;
    public TextMeshProUGUI dinerotxt;

    void Start()
    {
        indicepersonaje = PlayerPrefs.GetInt("Personaje");
        dinero = 100;        

        //PERSONAJE
        for (int i = 0; i < personajes.Length; i++)
        {
            if(i != indicepersonaje)
            {
                Destroy(personajes[i]);
            }
        }
    }

    void Update()
    {
        dinero = PlayerPrefs.GetInt("Dinero");
        dinerotxt.text = dinero.ToString();
        PlayerPrefs.SetInt("Dinero", dinero);
    }

    public void Mesa()
    {
        SceneManager.LoadScene("Inicio");

    }

    public void Cocina()
    {
        SceneManager.LoadScene("Cocina");

    }

    public void Bano()
    {
        SceneManager.LoadScene("Bano");
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

    public void Mapa()
    {
        mapa.SetActive(!(mapa.activeSelf));
    }

    public void Coliseo()
    {
        SceneManager.LoadScene("Runner");
    }

    public void Lago()
    {
        SceneManager.LoadScene("Pescar");
    }

    public void Boutique()
    {
        SceneManager.LoadScene("Boutique");
    }

    public void Mercado()
    {
        SceneManager.LoadScene("Mercado");
    }
}
