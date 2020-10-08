using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class llanta : MonoBehaviour
{
    // Start is called before the first frame update
  
    public float velocidad = 600;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.right * Time.deltaTime * velocidad);
    }
}
