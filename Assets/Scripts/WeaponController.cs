using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponController : MonoBehaviour
{
    private Rigidbody2D rb;
    //bring spriterender
    private SpriteRenderer spriteRenderer;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        //get the spriterender
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        //if the player clicks on the left mouse button, set the isAttacking to true
        if(Input.GetMouseButtonDown(0)){
            //set the isAttacking to true
            Animator anim = GetComponentInParent<Animator>();
            anim.SetBool("isAttacking", true);
            Debug.Log("button pressed");
        }
        //if the player clicks on the left mouse button, set the isAttacking to false
        if(Input.GetMouseButtonUp(0)){
            //set the isAttacking to false
            Animator anim = GetComponentInParent<Animator>();
            anim.SetBool("isAttacking", false);
            Debug.Log("button pressed");
        }

        
        }
}