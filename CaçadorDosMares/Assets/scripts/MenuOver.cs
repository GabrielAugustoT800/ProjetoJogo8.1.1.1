using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MenuOver : MonoBehaviour
{
    [SerializeField] private GameObject MenuInicial;
    [SerializeField] private GameObject GameOver;
    public void ShowGameOverScreen()
    {
        GameOver.SetActive(true);
    }
    public void Restart()
    {
        SceneManager.LoadScene(1);
    }

    public void Menu()
    {
        GameOver.SetActive(false);
        MenuInicial.SetActive(true);
    }
}
