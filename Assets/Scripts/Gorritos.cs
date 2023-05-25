using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Gorritos : MonoBehaviour
{
    public Image imagen;
    public Sprite[] gorritos;
    private int indice;
    public TextMeshProUGUI preciotxt;
    public int[] precios;
    //public GameObject panel;

    void Start()
    {
        indice = 0;
        
    }

    // Update is called once per frame
    void Update()
    {
        imagen.sprite = gorritos[indice];
        preciotxt.text = precios[indice].ToString();
    }

    public void Siguiente()
    {
        if (indice < gorritos.Length - 1)
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
            indice = 12;
        }
    }

}
