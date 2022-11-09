// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;
// using UnityEngine.Audio;

// public class PlayerShooting : MonoBehaviour
// {
//     public Transform firePoint;
//     public GameObject bulletPrefab;
//     public float bulletForce = 20f;
//     //public AudioSource audioSource;
//     public AudioSource audioSource;

//     //bring uiController into the script
//     public uiController uiController;

// //start uicontroller comp
//     void Start()
//     {
       
//         uiController = GetComponent<uiController>();
//     }

//     // Update is called once per frame
//     void Update()
//     {
       
//        //if amountCount is greater than 0 debu log "yes"
//         // if(uiController.amountCount > 0){
//         //     Debug.Log("yes");
//         //     //if the player clicks on the left mouse button
//         //     if(Input.GetButtonDown("Fire1")){
//         //         //play the audio source
//         //         audioSource.Play();
//         //         //shoot the bullet
//         //         Shoot();
//         //         //subtract 1 from the amountCount
//         //         uiController.amountCount -= 1;
//         //         //update the amountCount
//         //         uiController.UpdateBullets(uiController.amountCount);
//         //     }
//         // }

//         //shoot
//         if(Input.GetButtonDown("Fire1")){
//             Shoot();
//         }
       
    
//     }
//     void Shoot(){
//         GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
//         Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
//         rb.AddForce(firePoint.up * bulletForce, ForceMode2D.Impulse);
//         audioSource.Play();

     
     
       
//     }    
// }
