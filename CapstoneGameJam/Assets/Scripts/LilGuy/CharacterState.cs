using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class CharacterState : MonoBehaviour
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