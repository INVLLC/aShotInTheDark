using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//bring in WeaponsLogic.cs
using UnityEngine.UI;

public class uiController : MonoBehaviour
{
    WeaponsLogic weaponsLogic;
    [SerializeField] GameObject wLogic;
    void Awake()
    {
        weaponsLogic = wLogic.GetComponent<WeaponsLogic>();
        }

        void Start()
        {
        
        Debug.Log(weaponsLogic.PlayerHasBulletForWeapon);
        

            
        }

    void Update()
    {
        
        
    }
}
