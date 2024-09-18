using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class AudioTestGuy : MonoBehaviour
{
    [SerializeField] AudioClip attackSound;
    [SerializeField] AudioManager theAudioManager;

    public Rigidbody rb;
    public float moveSpeed = 5f;
    public PlayerInputActions playerControls;
    //public InputAction playerClick;

    Vector2 moveDirection = Vector2.zero;
    private InputAction move;
    private InputAction fire;
    //bool isClicking = false;


    private void Awake()
    {
        playerControls = new PlayerInputActions();
    }

    private void OnEnable()
    {
        move = playerControls.Player.Move;
        move.Enable();
        fire = playerControls.Player.Fire;
        fire.Enable();
        fire.performed += Fire;
        //playerControls.Enable();
    }

    private void OnDisable()
    {
        //playerControls.Disable();
        move.Disable();
        fire.Disable();
    }

    // Update is called once per frame
    void Update()
    {
        //float moveX = Input.GetAxis("Horizontal");
        //float moveY = Input.GetAxis("Vertical");

        moveDirection = move.ReadValue<Vector2>();
        
    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector2(moveDirection.x * moveSpeed, moveDirection.y * moveSpeed);
    }

    private void Fire(InputAction.CallbackContext context)
    {
        theAudioManager.PlaySfx(attackSound,this.transform,1f);
    }

}
