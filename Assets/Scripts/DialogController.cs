using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Animations;

public class DialogController : MonoBehaviour
{

    public void dialogController()
    {
        //set the bool of "IntroDialogHide"
        Animator anim = GetComponentInParent<Animator>();
        anim.SetBool("IntroDialogHide", true);
        Debug.Log("button pressed");





    }
}
