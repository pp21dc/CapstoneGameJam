using System.Collections;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using UnityEngine;

public class LilGuyBase : MonoBehaviour
{
    [Range(1, 100)] private int speed;
    [Range(1, 100)] private int stamina;
    [Range(1, 100)] private int strength;

    private CharacterState state;

    public virtual void AttackLight() { }

    public virtual void AttackHeavy() { }

}
