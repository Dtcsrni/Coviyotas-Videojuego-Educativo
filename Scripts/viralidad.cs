using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI; // Required when Using UI elements.


public class viralidad : MonoBehaviour
{
     

    // Start is called before the first frame update
    public Slider slider;
    public void aumentarViralidad()
    {
        slider.value +=0.3F;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "persona")
        {
            aumentarViralidad();
        }
        
    }

    private void Update()
    {
    
    }

}
