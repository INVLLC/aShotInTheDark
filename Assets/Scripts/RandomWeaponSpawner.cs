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
    public uiController uiController;





    //start
    void Start()
    {
        for (int i = 0; i < WeaponsPerSpawner; i++)
        {
            SpawnWeapon();
        }
        
    }

    void SpawnWeapon()
    {
        GameObject weaponSpawn;
        weaponSpawn = Instantiate(weapons[Random.Range(0, weapons.Length)], transform.position + Random.insideUnitSphere * Radius, Quaternion.identity, transform);
        
        weaponSpawn.GetComponent<ObjectLogic>().uiController = uiController;
        
       
    }



    private void OnDrawGizmosSelected()
    {
       
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, Radius);
    }


    // void Update()
    // {
    //     if (transform.childCount < WeaponsPerSpawner)
    //     {
    //         SpawnWeapon();
    //     }
    // }
}
