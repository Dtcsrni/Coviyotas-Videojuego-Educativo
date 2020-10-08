using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityStandardAssets.Cameras;
using UnityStandardAssets.Characters.ThirdPerson;

public class muerte : MonoBehaviour
{
    
    ContactPoint contact;
    GameObject camara;
    GameObject Jugador;
    Renderer rend;
    private IEnumerator coroutine;
    public Slider viral;

    // Start is called before the first frame update
    void Start()
    {
        setRigidbodyState(true);
        setColliderState(false);
        Jugador = GetComponent<GameObject>();
        camara = GameObject.Find("Camara");
        rend = GameObject.FindGameObjectWithTag("pielJugador").GetComponent<Renderer>();
     
        viral.GetComponent<Slider>();
    }

    // Update is called once per frame
    void Update()
    {
        if (viral.value == 1)
        {
            morir(2);
        }
    }

    public void morir(int tipo)
    {

        
        
        GetComponent<Animator>().enabled = false;
        
        setRigidbodyState(false);
        setColliderState(true);
        GetComponent<Rigidbody>().isKinematic = false;
        gameObject.GetComponent<ThirdPersonUserControl>().enabled = false;
        gameObject.GetComponent<ThirdPersonCharacter>().enabled = false;
        camara.GetComponent<AutoCam>().enabled = false;
        GetComponent<Rigidbody>().AddExplosionForce(5000, contact.point - transform.position, 1000, 800, ForceMode.Force);
        rend.material.shader = Shader.Find("Universal Render Pipeline/Lit");
        if (tipo == 1)
        {
            rend.material.SetColor("_BaseColor", Color.red);
        }
        if (tipo == 2)
        {
            rend.material.SetColor("_BaseColor", Color.blue);
        }




        StartCoroutine(repetidor());



    }
    void setRigidbodyState(bool state)
    {
        Rigidbody[] rigidbodies = GetComponentsInChildren<Rigidbody>();

        foreach(Rigidbody rigidbody in rigidbodies)
        {
            rigidbody.isKinematic = state;
        }
        GetComponent<Rigidbody>().isKinematic = !state;
    }
    void setColliderState(bool state)
    {
        Collider[] colliders = GetComponentsInChildren<Collider>();

        foreach (Collider collider in colliders)
        {
            collider.enabled = state;
        }
        GetComponent<Collider>().enabled = !state;
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "carro")
        {
            contact = collision.GetContact(0);
            morir(1);
        }
    }
    private IEnumerator repetidor()
    {
        yield return new WaitForSeconds(4);
        reiniciarEscena();
    }
    void reiniciarEscena()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
