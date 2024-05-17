using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerCollision : MonoBehaviour
{
    public GameObject gameOverControllerOwner;
    public MenuOver gameOverController; // Referência ao controlador de Game Over
    private void Start()
    {
        gameOverController = GetComponent<MenuOver>();
    }
    void OnTriggerEnter(Collider other)
    {
        // Verifica se o player colidiu com um objeto com a tag "Player"
        if (other.CompareTag("barco"))
        {
            SceneManager.LoadScene(0);
            // Chama a função para exibir a tela de Game Over
            //gameOverController.ShowGameOverScreen();
        }
    }
}
