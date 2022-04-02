using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DioAttack : MonoBehaviour
{
    public Animator animator;
    public Transform atackPoint;
    public LayerMask enemyLayer;
    public float ranger = 0.5f;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            Attack();
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            AttackLeg();
        }
    }
    void Attack()
    {
        animator.SetTrigger("hit arm");
        Collider2D[] hitenemy = Physics2D.OverlapCircleAll(atackPoint.position, ranger, enemyLayer);
        foreach(Collider2D enemy in hitenemy)
        {
            enemy.GetComponent<Jotaro>().Takedamage(20);
        }
    }
    void AttackLeg()
    {
        animator.SetTrigger("hit leg");
        Collider2D[] hitenemy = Physics2D.OverlapCircleAll(atackPoint.position, ranger, enemyLayer);
        foreach (Collider2D enemy in hitenemy)
        {
            enemy.GetComponent<Jotaro>().Takedamage(30);
        }
    }
    void OnDrawGizmos()
    {
        if (atackPoint == null)
            return;
        Gizmos.DrawWireSphere(atackPoint.position, ranger); 
    }
}
