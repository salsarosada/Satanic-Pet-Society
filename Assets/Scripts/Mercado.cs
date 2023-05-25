using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Mercado : MonoBehaviour
{
    public Image imagen;
    public Sprite[] comida;
    private int indice;
    public TextMeshProUGUI preciotxt;
    public int[] precios;
    private int dinero;
    //public GameObject panel;
    private SpriteRenderer spriteRenderer;
    public GameObject[] prefabComida;
    public Animator animator;
    public Transform personaje;

    void Start()
    {
        indice = 0;
        dinero = PlayerPrefs.GetInt("Dinero");
    }

    // Update is called once per frame
    void Update()
    {
        imagen.sprite = comida[indice];
        preciotxt.text = precios[indice].ToString();
    }

    public void Siguiente()
    {
        if (indice < comida.Length - 1)
        {
            indice++;
        }
        else
        {
            indice = 0;
        }
    }

    public void Anterior()
    {
        if (indice > 0)
        {
            indice--;
        }
        else
        {
            indice = 2;
        }
    }

    public void Comprar()
    {
        if (dinero >= precios[indice])
        {
            dinero -= precios[indice];
            PlayerPrefs.SetInt("Dinero", dinero);
            spriteRenderer.sprite = comida[indice];
            GameObject comidita = Instantiate(prefabComida[indice], personaje);
            
        }
        else
        {
            Debug.Log("saldo insuficiente");
        }
    }
}
