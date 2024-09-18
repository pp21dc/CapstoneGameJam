using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using static UnityEngine.InputSystem.InputAction;

public class CharacterState : MonoBehaviour
{
    public bool isMoving, isJumping, isAttacking, isUsingSpecial = false;
    public void OnMove(CallbackContext ctx)
    {
        isMoving = true;
        Debug.Log(ctx.ReadValue<Vector2>());
    }
    public void OnJump(CallbackContext ctx)
    {
        isJumping = true;
        Debug.Log(ctx.ReadValue<bool>());
    }
    public void OnAttack(CallbackContext ctx)
    {
        isAttacking = true;
        Debug.Log(ctx.ReadValue<bool>());
    }
    public void OnSpecial(CallbackContext ctx)
    {
        isUsingSpecial = true;
        Debug.Log(ctx.ReadValue<bool>());
    }
    virtual public CharacterState handleInput()
    {
        return this;
    }
}


class IdleState : CharacterState
{

    override public CharacterState handleInput()
    {
        //Receives movement input
        if (isMoving)
            return new WalkingState();
        // Receives jump input
        if (isJumping)
            return new JumpingState();
        // Receives attacking input
        if (isAttacking)
            return new AttackingState();
        //Receives special input
        if (isUsingSpecial)
            return new SpecialState();


        return this;
    }
}

class JumpingState : CharacterState
{
    private bool IsGrounded()
    {
        if(Physics.Raycast(transform.position, Vector3.down, 5, 3))
            return true;
        else return false;
    }
    override public CharacterState handleInput()
    {
        if (IsGrounded())
        {
            if (isAttacking)
                return new AttackingState();
            if (isUsingSpecial)
                return new SpecialState();
            if (isMoving)
                return new WalkingState();
            else
                return new IdleState();            
        }
        return this;
    }
}

class WalkingState : CharacterState
{
    public override CharacterState handleInput()
    {
        if (!isMoving)
            return new IdleState();
        if (isJumping)
            return new JumpingState();
        if (isAttacking)
            return new AttackingState();
        if (isUsingSpecial)
            return new SpecialState();
        return this;
    }
}

class AttackingState : CharacterState
{
    public override CharacterState handleInput()
    {
        if (isMoving)
            return new WalkingState();
        if (isJumping) 
            return new JumpingState();
        if (isAttacking)
            return new AttackingState();
        if (isUsingSpecial)
            return new SpecialState();
        return this;
    }
}
class SpecialState : CharacterState
{
    public override CharacterState handleInput()
    {
        if (isMoving)
            return new WalkingState();
        if (isJumping)
            return new JumpingState();
        if (isAttacking)
            return new AttackingState();
        if (isUsingSpecial)
            return new SpecialState();
        return this;
    }
}