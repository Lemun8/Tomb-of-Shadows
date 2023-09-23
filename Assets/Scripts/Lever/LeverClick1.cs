using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeverClick1 : MonoBehaviour
{
    [SerializeField] private Animator AnimationControl;

    private void OnMouseDown()
    {
        AnimationControl.SetTrigger("LevelClick1");
    }
}
