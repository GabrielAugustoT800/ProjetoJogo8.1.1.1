using System.Collections;
using System.Collections.Generic;
using Unity.Collections;
using UnityEngine;

public class cameraController : MonoBehaviour
{
    // Start is called before the first frame update
    public float velocity = 10.0f;
    public float rotation = 90.0f;



    void Start()
    {
        
    }

    // Update is called once per frame
   void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");

    }
}
