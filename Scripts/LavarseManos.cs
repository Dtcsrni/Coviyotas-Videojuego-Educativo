using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.Characters.ThirdPerson;

public class LavarseManos : MonoBehaviour
{
    // Start is called before the first frame update
    private Animator anim;
    public Transform shoulder;
    public float viralidad;
    public Slider viral;
    public GameObject letrero;

    void Awake()
    {
        anim = GetComponent<Animator>();
        viral.GetComponent<Slider>();
        letrero.GetComponent<GameObject>();
    }

    // Update is called once per frame
    void Update()
    {   
       
    }
    private void OnCollisionStay(Collision collision)
    {
        Vector3 direction;
        if (collision.gameObject.tag == "lavabo")
        {
            letrero.SetActive(true);

            if (Input.GetKeyDown(KeyCode.L))
            {
                direction = transform.position - collision.gameObject.transform.position;
                if (Mathf.Abs(direction.x) > Mathf.Abs(direction.y))
                {

                    if (direction.x > 0) { print("collision is to the right"); }
                    else { print("collision is to the left");
                        anim.SetTrigger("cercaLavabo");
                        gameObject.GetComponent<ThirdPersonUserControl>().enabled = false;
                        gameObject.GetComponent<ThirdPersonCharacter>().enabled = false;
                        GetComponent<Rigidbody>().isKinematic = true;
                        transform.LookAt(collision.transform);
                        viral.value = 0;
                    }

                }
                else
                {

                    if (direction.y > 0) { print("collision is up"); }
                    else { print("collision is down"); }
                }

                
            }

        }


    }
    private void OnCollisionExit(Collision collision)
    {
        letrero.SetActive(false);
    }

    private void Habilitar()
    {
        gameObject.GetComponent<ThirdPersonUserControl>().enabled = true;
        gameObject.GetComponent<ThirdPersonCharacter>().enabled = true;
        GetComponent<Rigidbody>().isKinematic = false;
        

    }
}