using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeverClick3 : MonoBehaviour
{
    [SerializeField] private Animator AnimationControl;

    private void OnMouseDown()
    {
        AnimationControl.SetTrigger("LeverClick3");
    }
}
