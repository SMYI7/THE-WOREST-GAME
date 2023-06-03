using System.Collections;
using System.Collections.Generic;
using System.Threading;
using Unity.VisualScripting;
using UnityEngine;

public class SowredHit : MonoBehaviour
{
    public LayerMask hitMask;
    public Transform SowrdPosition;
    public float SowrdRadius;
    public bool GetDamege;

 
    
    private void Update()
    {
       if (Input.GetMouseButtonDown(0))
        {
            Attack();
        }
        
    }
    void Attack()
    {
        Collider2D[] enemyHitted = Physics2D.OverlapCircleAll(SowrdPosition.position, SowrdRadius, hitMask);
       

     foreach (Collider2D enemies in  enemyHitted)
        {
            Debug.Log("We Hit " + enemies.name);
        }
    }
    private void OnDrawGizmos()
    {
        Gizmos.DrawWireSphere(SowrdPosition.position, SowrdRadius);
    }
}
