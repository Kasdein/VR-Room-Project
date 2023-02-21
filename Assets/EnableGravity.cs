using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnableGravity : MonoBehaviour
{
    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>(); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TurnOnTheGravity()
    {
        rb.useGravity = true;
    }

    public void TurnOffTheGravity()
    {
        rb.useGravity = false;
    }
}