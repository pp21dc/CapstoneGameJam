using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AiEnemyTEMP : MonoBehaviour
{
    public int health = 25;
    private const int MAX_HEALTH = 25;

    private int ticks = 0;
    private const int regenRate = 400;

    [SerializeField] private GameObject hitbox;
    GameObject playerRef;

    private void Death() { Destroy(this.gameObject, 0.5f); }

    private void Attack() 
    {
        GameObject temp = Instantiate(hitbox, transform.position + transform.forward * 0.5f, Quaternion.identity);
        temp.transform.SetParent(transform);
        Destroy(temp, 1f);
    }

    private void Awake()
    {
        playerRef = GameObject.FindGameObjectWithTag("Player");
    }

    private void Update()
    {
        if (Physics.Raycast(transform.position, playerRef.transform.position - transform.position, out RaycastHit hit, 5.0f) && hit.collider.CompareTag("Player"))
        {
            Attack();
        }
    }

    private void FixedUpdate()
    {
        if (health <= 0) { 
            Death(); 
            return; 
        }
        if (health != MAX_HEALTH)
        {
            if (ticks < regenRate)
            {
                ticks++;
            }
            else
            {
                ticks = 0;
                health = MAX_HEALTH;
            }
        }
    }
}
