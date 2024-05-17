using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class MensagemLimit : MonoBehaviour
{
    private TextMeshProUGUI messageText;

    // Start is called before the first frame update
    private void Start()
    {
    
        messageText = GetComponent<TextMeshProUGUI>();
        messageText.enabled = false;

    }

    public void ShowMessage(string message)
    {
        messageText.text = message; 
        messageText.enabled = true;
    }

    // Update is called once per frame
    public void HideMessage()
    {
        messageText.enabled = false;

    }
}
