using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlashlightToggle : MonoBehaviour
{
    public GameObject Light;
    public bool toggle;
    public AudioSource toggleSound;

    void Start()
    {
        if(toggle == false)
        {
            Light.SetActive(false);
        }
        if(toggle == true)
        {
            Light.SetActive(true);
        }
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            toggle = !toggle;
            toggleSound.Play();
            if (toggle == false)
            {
                Light.SetActive(false);
            }
            if (toggle == true)
            {
                Light.SetActive(true);
            }
        }
    }
}
