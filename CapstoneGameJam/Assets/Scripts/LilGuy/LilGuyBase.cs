using System.Collections;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using UnityEngine;

public class LilGuyBase : MonoBehaviour
{
    public string guyName;
    public int heath;
    [Range(1, 100)] public int speed;
    [Range(1, 100)] public int stamina;
    [Range(1, 100)] public int strength;

    private CharacterState state;

    public virtual void AttackLight() { }

    public virtual void AttackHeavy() { }

    public LilGuyBase(string guyName, int heath, int speed, int stamina, int strength, CharacterState state)
    {
        this.guyName = guyName;
        this.heath = heath;
        this.speed = speed;
        this.stamina = stamina;
        this.strength = strength;
        this.state = state;
    }
}
