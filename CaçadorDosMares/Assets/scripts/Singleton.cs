using UnityEngine;

public class Singleton : MonoBehaviour
{
    public static Singleton Instance;

    private void Awake()
    {
        Instance = this;
    }

    public void Metodo()
    {
        Debug.Log("Funcionou");
    }
}
