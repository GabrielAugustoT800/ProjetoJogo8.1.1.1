using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimentoPegar : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Trash"))
        {

        }
    }
}
