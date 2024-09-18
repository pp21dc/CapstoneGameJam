using UnityEngine;
using UnityEngine.InputSystem;

public class InputHandler : MonoBehaviour
{
    //PLAYER BODY REF
    private Player player;
    private Animator anim;

    private void Awake()
    {
        player = GetComponent<Player>();
        anim = GetComponent<Animator>();
    }

    public void OnMove(InputAction.CallbackContext context)
    {
        Vector2 moveVec = context.ReadValue<Vector2>();
        player.MoveVector = moveVec;
        anim.SetBool("isMoving", moveVec != Vector2.zero);
    }

    public void OnJump(InputAction.CallbackContext context)
    {
        player.Jump();
        anim.SetTrigger("Jump");
    }

    public void OnAttack(InputAction.CallbackContext context)
    {
        player.Attack();
        anim.SetTrigger("Attack");

    }

    public void OnSpecial(InputAction.CallbackContext context)
    {
        anim.SetTrigger("Special");
        player.Special();
    }

    public void OnShowStatScreen(InputAction.CallbackContext context)
    {
        player.ShowStatScreen();
    }
}
