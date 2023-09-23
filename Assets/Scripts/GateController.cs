using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GateController : MonoBehaviour
{
    public GameObject Gate1;
    public bool gateIsOpening;
    public bool hasOpenedOnce = false; 
    public AudioSource gateOpen;
    public AudioSource leverClick;

    void Update()
    {
        if (gateIsOpening)
        {
            Gate1.transform.Translate(Vector3.up * Time.deltaTime * 5);
        }
        if (Gate1.transform.position.y > 7f)
        {
            gateIsOpening = false;
        }
    }

    void OnMouseDown()
    {
        if (!hasOpenedOnce) 
        {
            gateIsOpening = true;
            gateOpen.Play();
            leverClick.Play();
            hasOpenedOnce = true; 
        }
    }
}