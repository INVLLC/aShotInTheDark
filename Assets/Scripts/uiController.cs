using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class uiController : MonoBehaviour
{
    //var amountCount
    public int amountCount = 1;
    public int specialItems = 0;
    //start function
    //make a list of bullets
    public List<GameObject> bullets = new List<GameObject>();
    public List<GameObject> dpad = new List<GameObject>();
    //make a list for batteries
    
    //funct update amountn coin
    public void UpdateBullets(int amount)
    {
       //check if the amount if greater than 2 and enable the bullet
        if(amountCount > 1)
        {
            bullets[amountCount - 1].SetActive(true);
        }
        //add the amount to the amount count
        amountCount += amount;
        //check if the amount count is greater than 2 and enable the bullet
        if(amountCount > 1)
        {
            bullets[amountCount - 1].SetActive(true);
        }
    }

    //updateSpecialItem
    public void UpdateSpecialItem(int amount)
    {
        //check if the amount if greater than 2 and enable the bullet
       
    }
    

    
    
    








}
