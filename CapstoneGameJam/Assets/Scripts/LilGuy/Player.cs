using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class Player : MonoBehaviour
{
    //--------------VARIABLES--------------

    //LIL GUY MANAGEMENT
    private List<LilGuyBase> lilGuys = new List<LilGuyBase>(teamSize);
    private int currentLilGuy;
    private const int teamSize = 3;
    private Transform primaryHolder;
    private Transform secondaryHolder;
    private Transform tertiaryHolder;

    //GAMEJAM TEMP
    [SerializeField] private GameObject strPrefab;

    //MOVEMENT
    private const float moveSpeed = 25.0f;
    private const float jumpForce = 5.0f;
    private Vector2 moveVector;
    private Rigidbody rb;

    //STAT SCREEN
    [SerializeField] private GameObject statScreen;
    [SerializeField] private TMP_Text strText;
    [SerializeField] private TMP_Text staText;
    [SerializeField] private TMP_Text spdText;
    [SerializeField] private TMP_Text hpText;
    public Vector2 MoveVector { get { return moveVector; } set { moveVector = value; } }

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
        lilGuys.Add(strPrefab.GetComponent<LilGuyBase>());
        //Debug.Log(lilGuys[0].name.ToString());
    }

    public void Move(Vector2 input)
    {
        Vector3 moveDirection = new Vector3(input.x, 0f, input.y).normalized;
        Vector3 velocity = moveDirection * moveSpeed;
        rb.velocity = new Vector3(velocity.x, rb.velocity.y, velocity.z);

    }

    public void ShowStatScreen()
    {
        /*spdText.text = "SPD: " + lilGuys[0].speed;
        strText.text = "STR: " + lilGuys[0].strength;
        staText.text = "STA: " + lilGuys[0].stamina;
        hpText.text = "HP: " + lilGuys[0].heath;*/
        statScreen.SetActive(!statScreen.active);
    }
    private void OnDrawGizmos()
    {
        
    }
    public void Jump()
    {
        int layerMask = 1 << 3;
        //TODO: jump :3
        if (Physics.Raycast(transform.position, Vector3.down, 5, layerMask))
        {
            Debug.DrawRay(transform.position, Vector3.down, Color.red);
            Debug.Log("Jumped");
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }
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
