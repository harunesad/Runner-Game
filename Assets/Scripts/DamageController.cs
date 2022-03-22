using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DamageController : MonoBehaviour
{
    [SerializeField] private int damage;
    [SerializeField] private HealthController healthController;
    private Animator animator;
    private void Start()
    {
        animator = GetComponentInChildren<Animator>();
    }
    void Damage()
    {
        healthController.playerHealth = healthController.playerHealth - damage;
        healthController.UpdateHealth();
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            animator.SetTrigger("Stumble");
            animator.SetFloat("Speed", 5);
            Damage();
        }
    }
}
