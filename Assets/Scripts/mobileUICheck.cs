using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


public class mobileUICheck : MonoBehaviour
{
  
    void Start()
    {
      
        gameObject.SetActive(Application.isMobilePlatform);   
  
        
    }

  

}
