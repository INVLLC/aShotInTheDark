using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 1f;
    public float collisionOffset = 0.5f;
    public ContactFilter2D movementFilter;

    SpriteRenderer spriteRenderer;

    Vector2 movementInput;
    Rigidbody2D rb;
    Animator anim;
    List<RaycastHit2D> castCollisions = new List<RaycastHit2D>();

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void FixedUpdate(){
        if(movementInput != Vector2.zero){
            bool sucess = TryMove(movementInput);

            if(!sucess){
                // try to move in the x direction
                sucess = TryMove(new Vector2(movementInput.x, 0));
                if(!sucess){
                    // try to move in the y direction
                    sucess = TryMove(new Vector2(0, movementInput.y));
                }
            }
                anim.SetBool("isWalkingSide", true);
            } else {
                anim.SetBool("isWalkingSide", false);

            }
        
        //if a player clicks on the a or D key, change flipX to true or false and set the isWalkingSide to true. If a player clicks on W set the isWalkingSide to false and set the isWalkingBackToCam to true. if a player clicks on the S key set the isWalkingSide to false and set the isWalkingFacingCam to true.
        if(movementInput.x > 0){
            spriteRenderer.flipX = true;
            anim.SetBool("isWalkingSide", true);
            anim.SetBool("isWalkingBackToCam", false);
            anim.SetBool("isWalkingFacingCam", false);
        } else if(movementInput.x < 0){
            spriteRenderer.flipX = false;
            anim.SetBool("isWalkingSide", true);
            anim.SetBool("isWalkingBackToCam", false);
            anim.SetBool("isWalkingFacingCam", false);
        } else if(movementInput.y > 0){
            anim.SetBool("isWalkingSide", false);
            anim.SetBool("isWalkingBackToCam", true);
            anim.SetBool("isWalkingFacingCam", false);
        } else if(movementInput.y < 0){
            anim.SetBool("isWalkingSide", false);
            anim.SetBool("isWalkingBackToCam", false);
            anim.SetBool("isWalkingFacingCam", true);
        } else {
            anim.SetBool("isWalkingSide", false);
            anim.SetBool("isWalkingBackToCam", false);
            anim.SetBool("isWalkingFacingCam", false);
        }
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        // if(movementInput.x < 0){

        //     spriteRenderer.flipX = false;

        // } else if(movementInput.x > 0){

        //     spriteRenderer.flipX = true;

        // } else if(movementInput.y > 0){

        //     anim.SetBool("isWalkingSide", false);
        //     anim.SetBool("isWalkingBackToCam", true);

        // } else if(movementInput.y < 0){

        //    //if player then set other bool to false and set isWalkingFacingCam to true
        //     anim.SetBool("isWalkingSide", false);
        //     anim.SetBool("isWalkingBackToCam", false);
        //     anim.SetBool("isWalkingFacingCam", true);
       
         
        // } // else if there is NO movement input, set all to false
        // else {

        //     anim.SetBool("isWalkingFacingCam", false);
        //     anim.SetBool("isWalkingBackToCam", false);
        //     anim.SetBool("isWalkingSide", false);

        // }
        
        
    }

    private bool TryMove(Vector2 direction){
       int count = rb.Cast(
                    movementInput,
                    movementFilter,
                    castCollisions, 
                    moveSpeed * Time.fixedDeltaTime + collisionOffset);

            if(count == 0){
                    rb.MovePosition(rb.position + direction * moveSpeed * Time.fixedDeltaTime);
                    return true;
            } else {
                return false;
            }
    }

    void OnMove(InputValue movementValue)
    {
        movementInput = movementValue.Get<Vector2>();
      
    }
}
