using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DespejoLixo : MonoBehaviour
{
    GameObject player;
    bool Zona = false;
    private MensagemLimit messageController;
    
    public bool Colocou = false;
    public int contadorLixos = 0;
    // Start is called before the first frame update
    void Start()
    {
       
        player = GameObject.FindGameObjectWithTag("barco");
        messageController = FindObjectOfType<MensagemLimit>();

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

    // Update is called once per frame
    void Update()
    {
        LixoFora();
    }

    public void LixoFora()
    {
        if (player.GetComponent<PlayerInventory>().NumdeLixos >= 10)
        {

            if (Zona & Input.GetKeyDown(KeyCode.E))
            {
                player.GetComponent<PlayerInventory>().NumdeLixos = 0;
                
                Colocou = true;
                messageController.ShowMessage("lixo dispensado!");
            }


           
        }
        else if ((player.GetComponent<PlayerInventory>().NumdeLixos < 10) & (Input.GetKeyDown(KeyCode.E)))
        {
            messageController.ShowMessage("o seu barco não tem lixos!");
            Colocou = false;
        }
    }
}
