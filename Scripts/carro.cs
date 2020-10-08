using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class carro : MonoBehaviour
{
    // Start is called before the first frame update
    Transform goal;
    public GameObject objetivo;
    NavMeshAgent agent;
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();

        objetivo = GameObject.Find("esquinal");
        agent.destination = objetivo.transform.position;
    }

    // Update is called once per frame
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "esquinal")
        {
            objetivo = GameObject.Find("Objetivo1");
            agent.destination = objetivo.transform.position;
        }
        if (collision.gameObject.name == "Frontera")
        {
            Destroy(gameObject);
        }
    }

}
