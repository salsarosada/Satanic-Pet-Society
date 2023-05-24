using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class ObstaculoGenerador : MonoBehaviour
{
    public GameObject obstaculo;
    public float minVel;
    public float actualVel;
    public float velMult;
    public UIRunner ui;
    public TextMeshProUGUI velocidad;

    void Awake()
    {
        actualVel = minVel;
        GenerarObs();
    }

    public void GenerarObs()
    {
        GameObject ObsIns = Instantiate(obstaculo, transform.position, transform.rotation);
        ObsIns.GetComponent<Obs>().gen = this;
    }

    void Update()
    {
        if (ui.juego)
        {
            actualVel += velMult;
            velocidad.text = "Velocidad: " + Mathf.FloorToInt(actualVel);
        }        
    }
}
