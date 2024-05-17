using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerInventory : MonoBehaviour

{
    public int NumdeLixos { get; set; }
    public int contadorlixos;
    private MensagemLimit messageController;
    public UnityEvent<PlayerInventory> OnlixoColetado;
    bool Zona = false;
    public bool canCollect = true;

    public void lixoColetado()
    {
        

        if ((canCollect && NumdeLixos < 10))
        {

            NumdeLixos++;
            OnlixoColetado.Invoke(this);
            contadorlixos = +NumdeLixos;
           
           
            

            
        }


        else if (NumdeLixos >= 10)
        {
            canCollect = false;
            Debug.Log("O player não consegue mais coletar");
        }

        else
        {


        }
    }

    private void Start()
    {
        canCollect = true;
    }

    private void Update()
    {


        if (FindObjectOfType<DespejoLixo>().Colocou == true) 
        { 
            canCollect = true;
        }
    }
    public void LixoFora()
    {
        if (NumdeLixos >= 10)
        {

            if (Zona & Input.GetKeyDown(KeyCode.E))
            {
                NumdeLixos = 0;

                FindObjectOfType<DespejoLixo>().Colocou = true;
                messageController.ShowMessage("lixo dispensado!");
            }



        }
        else if ((NumdeLixos < 10) & (Input.GetKeyDown(KeyCode.E)))
        {
            messageController.ShowMessage("o seu barco não tem lixos!");
            FindObjectOfType<DespejoLixo>().Colocou = false;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("barco"))
        {
            Zona = true;
            messageController.ShowMessage("Clique no botão ' E'");
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("barco"))
        {
            Zona = false;
            messageController.HideMessage();
        }
    }
}
