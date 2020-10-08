using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms;

public class directorCarros : MonoBehaviour
{
    GameObject padreVehiculos;
    public GameObject moto;
    public GameObject carro1;
    public GameObject carro2;
    public GameObject carro3;
    public GameObject inicial;
    public GameObject[] carros;
    public int numero;
    private IEnumerator coroutine;

    private void Awake()
    {
        padreVehiculos = GameObject.Find("Vehiculos");
        carros = new GameObject[4];
        carros[0] = moto;
        carros[1] = carro1;
        carros[2] = carro2;
        carros[3] = carro3;
    }
    private void Start()
    {
        StartCoroutine(repetidor());
    }

    private void Update()
    {
      
    }
    private IEnumerator repetidor()
    {
        yield return new WaitForSeconds(2);
        instanciarCarro();
        StartCoroutine(repetidor());
    }
    private void instanciarCarro()
    {
        numero = Random.Range(0, 4);
        Instantiate(carros[numero], inicial.transform.position, inicial.transform.rotation, padreVehiculos.transform);
    }

  


}
