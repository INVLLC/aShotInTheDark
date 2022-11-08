using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectLogic : MonoBehaviour
{
    private Collider2D z_Collider;
    // [SerializeField] private ContactFilter2D z_ContactFilter;
    // private List<Collider2D> z_Collider2DList = new List<Collider2D>(1);
    // public AudioSource audioSource;
    public AudioClip audioClip;
    public uiController uiController;

    public int PlayerHasBulletForWeapon = 1;
    protected virtual void Start()
    {
        z_Collider = GetComponent<Collider2D>();
        
    }

    
    //make a OnCollisionEnter2D function
    void OnTriggerEnter2D(Collider2D other)
    {
        //if the player collides with the weapon
        if (other.gameObject.CompareTag("Player"))
        {
            uiController.UpdateBullets(PlayerHasBulletForWeapon); 
            other.gameObject.GetComponent<AudioSource>().PlayOneShot(audioClip);
            Destroy(gameObject);
           
    
        }
    }
   
}