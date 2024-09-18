using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    int minutes = 5;
    float secconds = 59f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        secconds -= Time.deltaTime;

        if (secconds < 0)
        {
            minutes -= 1;
            secconds = 59;
        }

        if (minutes < 0)
        {
            Time.timeScale = 0;
        }
    }
}
