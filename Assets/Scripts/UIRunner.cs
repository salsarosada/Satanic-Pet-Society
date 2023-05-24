using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIRunner : MonoBehaviour
{
    public GameObject menuPausa;
    public GameObject botonPausa;
    public bool juego = true;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Pausa()
    {
        Time.timeScale = 0f;
        botonPausa.SetActive(false);
        menuPausa.SetActive(true);
        juego = false;
    }

    public void Reanudar()
    {
        Time.timeScale = 1f;
        botonPausa.SetActive(true);
        menuPausa.SetActive(false);
        juego = true;
    }

    public void Terminar()
    {
        SceneManager.LoadScene("Inicio");
    }

    public void Reiniciar()
    {
        SceneManager.LoadScene("Runner");
    }
}
