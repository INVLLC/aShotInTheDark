using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//brin in sprite renderer
using UnityEngine.UI;


public class WeaponsLogic : ObjectLogic
{


//brin audioSource
    public AudioSource audioSource;
    public string WeaponName;
    public SpriteRenderer WeaponSprite;
    public int WeaponBatteryAmount;
    public Sprite WeaponBatteryHolderSprite;
    public int WeaponDamage;

    //int player has bullet for weapon
    public int PlayerHasBulletForWeapon = 1;

    // Start is called before the first frame update
    protected override void OnCollided(GameObject collidedObject)
    {
        //get audio source component
        audioSource = GetComponent<AudioSource>();

        //when a player collides with a weapon, play the sound, when the sound is done destroy the weapon and add +1 to the player's bullet count
        if (collidedObject.tag == "Player")
        {
            audioSource.Play();
            Destroy(gameObject, audioSource.clip.length);
            PlayerHasBulletForWeapon += 1;
                //debug log player bullet count
            Debug.Log(PlayerHasBulletForWeapon);
        }    

    }

   
}
