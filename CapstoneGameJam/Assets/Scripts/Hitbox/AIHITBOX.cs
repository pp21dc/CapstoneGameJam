using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIHITBOX : MonoBehaviour
{
    private int dmg;

    private static AIHITBOX instance;

    private void Awake()
    {
        instance = this;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            other.gameObject.GetComponent<LilGuyBase>().heath -= 1;
        }
    }
}
