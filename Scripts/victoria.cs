using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityStandardAssets.Characters.ThirdPerson;

public class victoria : MonoBehaviour
{
    public GameObject victoriaLetrero;

    // Start is called before the first frame update
    private Animator anim;
    private void Start()
    {
        anim = GetComponent<Animator>();
        victoriaLetrero.GetComponent<GameObject>();
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "casa")
        {
            Ganar();
        }
    }
    
    void Ganar()
    {
        anim.SetTrigger("victoria");
        victoriaLetrero.SetActive(true);
        gameObject.GetComponent<ThirdPersonUserControl>().enabled = false;
        gameObject.GetComponent<ThirdPersonCharacter>().enabled = false;
    }
}
