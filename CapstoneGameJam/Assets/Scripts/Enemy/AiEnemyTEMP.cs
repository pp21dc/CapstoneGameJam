using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AiEnemyTEMP : MonoBehaviour
{
    public int health = 25;
    private const int MAX_HEALTH = 25;

    private int ticks = 0;
    private const int regenRate = 400;


    private void FixedUpdate()
    {
        if (ticks < regenRate)
        {
            ticks++;
        }
        else
        {
            ticks = 0;
            health = MAX_HEALTH;
        }
    }
}
