using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class llanta2 : MonoBehaviour
{
    // Start is called before the first frame update

    public float velocidad = 600;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.forward * Time.deltaTime * velocidad);
    }
}
