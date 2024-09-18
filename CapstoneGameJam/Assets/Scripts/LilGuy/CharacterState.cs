using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
        if (Input.GetButtonDown("Move")) { return new WalkingState(); }
        else if (Input.GetButtonDown("Jump")) { return new JumpingState(); }
        else if (Input.GetButtonDown("Attack")) { return new AttackingState(); }
        else if (Input.GetButtonDown("Special")) { return new SpecialState(); }
        return this;
    }
}

class JumpingState : CharacterState
{
    override public CharacterState handleInput()
    {
        return new IdleState();
    }
}

class WalkingState : CharacterState
{
    public override CharacterState handleInput()
    {
        if (Input.GetButtonDown("Jump")) { return new JumpingState(); }
        else return this;
    }
}

class AttackingState : CharacterState
{
    public override CharacterState handleInput()
    {
        if (Input.GetButtonDown("Attack")) { return this; }
        else return new IdleState();
    }
}
class SpecialState : CharacterState
{
    public override CharacterState handleInput()
    {
        return this;
    }
}