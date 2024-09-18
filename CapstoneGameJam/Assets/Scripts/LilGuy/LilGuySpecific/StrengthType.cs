using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StrengthType : LilGuyBase
{
    private Transform attackPos;

    public StrengthType() : base("strengthGuy", 30, 30, PrimaryType.Strength, 25, 25, 50)
    {
    }

    public override void Special()
    {
        //TODO: ADD SPECIAL ATTACK
        base.Special();
    }
}
