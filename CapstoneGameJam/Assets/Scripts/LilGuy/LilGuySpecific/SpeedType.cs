using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedType : LilGuyBase
{
    private Transform attackPos;

    public SpeedType() : base("speedGuy", 30, 30, PrimaryType.Strength, 50, 25, 25)
    {
    }

    public override void Special()
    {
        //TODO: ADD SPECIAL ATTACK
        base.Special();
    }
}
