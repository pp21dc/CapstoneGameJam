using UnityEngine;
using UnityEngine.InputSystem;

public class InputHandler : MonoBehaviour
{
    //PLAYER BODY REF
    private Player player;

    private void Awake()
    {
        player = GetComponent<Player>();
    }

    public void OnMove(InputAction.CallbackContext context)
    {
        Vector2 moveVec = context.ReadValue<Vector2>();
        player.MoveVector = moveVec;
    }

    public void OnJump(InputAction.CallbackContext context)
    {
        player.Jump();
    }

    public void OnAttack(InputAction.CallbackContext context)
    {
        player.Attack();
    }

    public void OnSpecial(InputAction.CallbackContext context)
    {
        player.Special();
    }

    public void OnShowStatScreen(InputAction.CallbackContext context)
    {
        player.ShowStatScreen();
    }
}
