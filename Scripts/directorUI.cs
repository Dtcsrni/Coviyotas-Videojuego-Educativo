using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class directorUI : MonoBehaviour
{
    public GameObject mensaje1;
    public GameObject mensaje2;
    public GameObject mensaje3;
    public GameObject mensaje4;
    public GameObject mensaje5;
    public GameObject mensaje6;

    private IEnumerator coroutine;
    // Start is called before the first frame update

    private void Start()
    {
        mensaje1.GetComponent<GameObject>();
        mensaje2.GetComponent<GameObject>();
        mensaje3.GetComponent<GameObject>();
        mensaje4.GetComponent<GameObject>();
        mensaje5.GetComponent<GameObject>();
        mensaje6.GetComponent<GameObject>();

        StartCoroutine(activo(1, true, 0));
        StartCoroutine(activo(2, true, 3));
        StartCoroutine(activo(3, true, 4));
        StartCoroutine(activo(4, true, 5));
        StartCoroutine(activo(5, true, 6));

        StartCoroutine(activo(1, false, 7));
        StartCoroutine(activo(2, false, 8));
        StartCoroutine(activo(3, false, 9));
        StartCoroutine(activo(4, false, 10));



        
    }
    private IEnumerator activo(int mensaje, bool activo, int tiempo)
    {
        yield return new WaitForSeconds(tiempo);
        if (mensaje == 1)
        {
            mensaje1.SetActive(activo);
        }
        if (mensaje == 2)
        {
            mensaje2.SetActive(activo);
        }
        if (mensaje == 3)
        {
            mensaje3.SetActive(activo);
        }
        if (mensaje == 4)
        {
            mensaje4.SetActive(activo);
        }
        if (mensaje == 5)
        {
            mensaje5.SetActive(activo);
        }
        
    }


    // Update is called once per frame

}
