using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Puntaje : MonoBehaviour
{   
    private float puntos = 0;
    private TextMeshProUGUI textMesh;

    private void Start()
    {
        textMesh = GetComponent<TextMeshProUGUI>();
    }

    private void Update()
    {
        puntos += Time.deltaTime;
        textMesh.text = "Puntos: " + puntos.ToString("0");
    }

    public void sumarPuntos(float puntosEntrada)
    {
        puntos += puntosEntrada;
    }

}
