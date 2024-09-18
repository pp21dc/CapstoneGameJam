using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    //--------------VARIABLES--------------

    //LIL GUY MANAGEMENT
    private List<LilGuyBase> lilGuys = new List<LilGuyBase>();
    private int currentLilGuy;
    private const int teamSize = 3;

    //MOVEMENT
    private const float moveSpeed = 2.0f;
    private Rigidbody rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    public void Move(Vector2 input)
    {
        Vector3 moveDirection = new Vector3(input.x, 0f, input.y).normalized;
        Vector3 velocity = moveDirection * moveSpeed;
        rb.velocity = new Vector3(velocity.x, rb.velocity.y, velocity.z);

    }

    public void Jump()
    {
        //TODO: jump :3
    }

    public void Attack()
    {
        lilGuys[currentLilGuy].Attack();
    }

    public void Special()
    {
        lilGuys[currentLilGuy].Special();
    }

    private void SwapLilGuy()
    {
        currentLilGuy++;
    }

    private void AddToTeam()
    {
        //TODO: capture recently defeated enemy
    }

    void Update()
    {
        
    }
}
