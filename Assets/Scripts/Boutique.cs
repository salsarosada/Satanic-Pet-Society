using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boutique : MonoBehaviour
{
    public GameObject panel;

    public void Panel()
    {
        panel.SetActive(true);
    }

    public void Volver()
    {
        panel.SetActive(false);
    }
}
