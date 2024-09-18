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

    private void OnMove(InputAction.CallbackContext context)
    {
        Vector2 moveVec = context.ReadValue<Vector2>();
        player.Move(moveVec);
    }

    private void OnJump(InputAction.CallbackContext context)
    {
        player.Jump();
    }

    private void OnAttack(InputAction.CallbackContext context)
    {
        player.Attack();
    }

    private void OnSpecial(InputAction.CallbackContext context)
    {
        player.Special();
    }
}
