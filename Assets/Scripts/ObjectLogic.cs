using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectLogic : MonoBehaviour
{

    private Collider2D z_Collider;
    [SerializeField] private ContactFilter2D z_ContactFilter;
    private List<Collider2D> z_Collider2DList = new List<Collider2D>(1);
    protected virtual void Start()
    {
        z_Collider = GetComponent<Collider2D>();
    
        
    }

    // Update is called once per frame
    protected virtual void Update()
    {
        z_Collider.OverlapCollider(z_ContactFilter, z_Collider2DList);
        foreach(var o in z_Collider2DList)
        {
        OnCollided(o.gameObject);
        }        
    }

    protected virtual void OnCollided(GameObject collidedObject)
    {
        Debug.Log("Collided with: " + collidedObject.name);
    }
}
