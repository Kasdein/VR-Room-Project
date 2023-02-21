using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unpicked_magnifier : MonoBehaviour
{
    public Material Clear;
    public Material Mirror;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public void SetMatClear()
    {
        GetComponent<Renderer>().material = Clear;
    }

    public void SetMatMirror() 
    { 
        GetComponent<Renderer>().material = Mirror;
    }
}
