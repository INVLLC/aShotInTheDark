using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mobileUICheck : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        gameObject.SetActive(Application.isMobilePlatform);        
    }

}
