using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Player : MonoBehaviour
{
    //--------------VARIABLES--------------

    //LIL GUY MANAGEMENT
    private List<LilGuyBase> lilGuys = new List<LilGuyBase>();
    private int currentLilGuy;
    private const int teamSize = 3;
    private Transform primaryHolder;
    private Transform secondaryHolder;
    private Transform tertiaryHolder;

    //MOVEMENT
    private const float moveSpeed = 25.0f;
    private Vector2 moveVector;
    private Rigidbody rb;

    public Vector2 MoveVector { get { return moveVector; } set { moveVector = value; } }

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
        lilGuys[0] = GameObject.FindGameObjectWithTag("Guy").GetComponent<LilGuyBase>();
        Debug.Log(lilGuys[0].name.ToString());
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
        lilGuys[0].Attack();
    }

    public void Special()
    {
        lilGuys[0].Special();
    }

    private void SwapLilGuy()
    {
        //TODO: implement health checking and swap to next availible
        LilGuyBase holder = lilGuys[0];
        for (int i = 0; i < lilGuys.Count; i++)
        {
            lilGuys[i] = lilGuys[i + 1];
        }
        lilGuys[2] = holder;
        
    }

    private void AddToTeam()
    {
        //TODO: capture recently defeated enemy
    }

    void Update()
    {
        //lilGuys[0].State = lilGuys[0].State.handleInput();
    }

    private void FixedUpdate()
    {
        Move(moveVector);
    }
}
