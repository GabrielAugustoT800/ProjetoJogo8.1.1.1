using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class IInventory: MonoBehaviour
{
    public TextMeshProUGUI lixoText;
    

    void Start()
    {
        lixoText = GetComponent<TextMeshProUGUI>(); 
    
    }

    public void UpdatelixoText(PlayerInventory player)
    {
        lixoText.text = player.NumdeLixos.ToString();
       Debug.Log(player.NumdeLixos);
      
    }

    private void Update()
    {
        
    }
}
