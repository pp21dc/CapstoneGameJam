using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using static UnityEngine.InputSystem.InputAction;

public class CharacterState : MonoBehaviour
{
    virtual public CharacterState handleInput()
    {
        return this;
    }
}


class IdleState : CharacterState
{

    override public CharacterState handleInput()
    {
        return this;
    }
}

class JumpingState : CharacterState
{
    override public CharacterState handleInput()
    {
        return this;
    }
}

class WalkingState : CharacterState
{
    public override CharacterState handleInput()
    {
        return this;
    }
}

class AttackingState : CharacterState
{
    public override CharacterState handleInput()
    {
        return this;
    }
}
class SpecialState : CharacterState
{
    public override CharacterState handleInput()
    {
        return this;
    }
}