// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;

// public class WeaponRotate : MonoBehaviour
// {
//     private Rigidbody2D rb;
//     private Camera mainCamera;
    
//     Vector2 movement;
//     Vector2 mousePosisition;

//     // Start is called before the first frame update
//     void Start()
//     {
//         rb = GetComponent<Rigidbody2D>();
//         mainCamera = Camera.main;

        
//     }
//     //update
//     void Update()
//     {

//         mousePosisition = mainCamera.ScreenToWorldPoint(Input.mousePosition);
//     }

//     // Update is called once per frame
//     void FixedUpdate()
//     {
        
//         Vector2 lookDirection = mousePosisition - rb.position;
//         float angle = Mathf.Atan2(lookDirection.y, lookDirection.x) * Mathf.Rad2Deg - 90f;
//         rb.rotation = angle;
//     }
// }
