using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class DayNightCycle : MonoBehaviour
{
    [SerializeField] private Transform luzDirecional;
    [SerializeField][Tooltip("Duração do dia em segundos")] private int duracaoDoDia; //texto de dica para explicar a variável no Inspector
    

    private float segundos;
    private float multiplicador; // 1 dia tem 86400 segundos, a lógica é usar os segundos como contador

    // Start is called before the first frame update
    void Start()
    {
        multiplicador = 86400 / duracaoDoDia;
    }

    // Update is called once per frame
    void Update()
    {
        segundos += Time.deltaTime * multiplicador;

        if (segundos >= 86400)
        {
            segundos = 0; // se passou um dia inteiro, volta a variável para 0 para recomeçar o ciclo 
        }

        ProcessarCeu();
        
    }

    private void ProcessarCeu() //funcionamento do dia no Unity: 00h00 = -90° 06h00 = 0° 12h00 = 90° 18h00 = 180° 23h59 = 270°
    {
        float rotacaoX = Mathf.Lerp(-90, 270, segundos / 86400);  //interpola entre 2 valores
                                                                  //valor de interpolação entre 0 e 1. 0 retorna -90 e 1 retorna 270
        luzDirecional.rotation = Quaternion.Euler(rotacaoX, 0, 0); //outros valores não importam por isso deixo em 0

    }

    


}
