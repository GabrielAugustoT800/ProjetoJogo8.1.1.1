
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class boatmoviment : MonoBehaviour
{
    public float forwardSpeed = 5f;
    public float slowSpeed = 5f;
    public float reverseSpeed = 3f;
    public float rotationSpeed = 80f;
    public float terrainCheckDistance = 4f; // Distância para verificar se está perto do terreno


    private Rigidbody rb;

    private void Start()
    {
        
    rb = GetComponent<Rigidbody>();
    }
    void FixedUpdate()
    {
        // Captura de entrada de teclado para controle do barco
        float moveInput = Input.GetAxis("Vertical");
        float rotateInput = Input.GetAxis("Horizontal");

        // Calcula a direção do movimento
        Vector3 movementDirection = transform.forward;

        
       

        RaycastHit hit;
        if (Physics.Raycast(transform.position, Vector3.down, out hit, terrainCheckDistance))
        {
            // Se perto do terreno, reduzir a velocidade
            if (rb.velocity.magnitude > slowSpeed)
            {
                if (moveInput > 0) // Para frente
                {
                    transform.Translate(movementDirection * slowSpeed * Time.deltaTime, Space.World);
                }
            }
           
            // Aplica rotação

        }
        else
        {

            if (moveInput > 0) // Para frente
            {
                transform.Translate(movementDirection * forwardSpeed * Time.deltaTime, Space.World);
            }
            else if (moveInput < 0) // Para trás (ré)
            {
                transform.Translate(-movementDirection * reverseSpeed * Time.deltaTime, Space.World);
            }


            if (rotateInput != 0)
            {
                float rotationAmount = rotateInput * rotationSpeed * Time.deltaTime;
                transform.Rotate(Vector3.up, rotationAmount);
            }
        }


      

    }
}


