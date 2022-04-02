using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jotaro : MonoBehaviour
{
    public int maxHealth = 100;
    int currentHealth;
    public Animator animator;
    private void Start()
    {
        currentHealth = maxHealth;
    }
    public void Takedamage(int damage)
    {
        currentHealth -= damage;
        animator.SetTrigger("Hurt");

        if (currentHealth <= 0)
        {
            Die();
        }
    }
    void Die()
    {
        animator.SetBool("IsDie", true);
        this.enabled = false;
        GetComponent<Collider2D>().enabled = false;
    }
}
