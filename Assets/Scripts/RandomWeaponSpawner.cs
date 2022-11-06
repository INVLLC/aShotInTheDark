using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class RandomWeaponSpawner : MonoBehaviour
{

    public GameObject[] weapons;
    public float Radius = 1;
    public Tilemap tilemap;
    public float WeaponsPerSpawner = 3;




    //start
    void Start()
    {
        for (int i = 0; i < WeaponsPerSpawner; i++)
        {
            SpawnWeapon();
        }
    
        
        tilemap = GameObject.FindGameObjectWithTag("Obstacles").GetComponent<Tilemap>();
           


        
    }

    void SpawnWeapon()
    {
        Instantiate(weapons[Random.Range(0, weapons.Length)], transform.position + Random.insideUnitSphere * Radius, Quaternion.identity, transform);
        
       
    }



    private void OnDrawGizmosSelected()
    {
       
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, Radius);
    }


    void Update()
    {
        if (transform.childCount < WeaponsPerSpawner)
        {
            SpawnWeapon();
        }
    }
}
