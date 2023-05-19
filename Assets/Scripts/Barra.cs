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
    public GameObject cam;
    public Transform[] puntos;
    public float vel;
    public Transform mov;
    public Animator animPanelBlanco;
    private int indicepersonaje;
    public GameObject[] personajes;

    void Start()
    {
        indicepersonaje = PlayerPrefs.GetInt("Personaje");
        mov = puntos[0];

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
        cam.transform.position = Vector3.Lerp(cam.transform.position, mov.position, vel * Time.deltaTime);
    }

    public void Mesa()
    {
        barra.sprite = mesa;
        animPanelBlanco.SetTrigger("Cambio");
        mov = puntos[0];
        
    }

    public void Cocina()
    {
        barra.sprite = cocina;
        animPanelBlanco.SetTrigger("Cambio");
        mov = puntos[1];
        
    }

    public void Bano()
    {
        barra.sprite = bano;
        animPanelBlanco.SetTrigger("Cambio");
        mov = puntos[2];
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
