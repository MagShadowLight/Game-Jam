using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Statuseffect : MonoBehaviour
{

    public bool Burned = false;
    public bool Frozen = false;
    public bool Stunned = false;
    public float Timer = 2.0f;
    public float TimerUntilEnd = 5.0f;
    public PlayerController PC;

    // Start is called before the first frame update
    void Start()
    {
        PC = gameObject.GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Timer > 0)
        {
            Timer -= Time.deltaTime;
        }
        if (Burned == true)
        {
            if (Timer <= 0.0)
            {
                PC.Health -= 1;
                Timer = 2.0f;
            }
            if (TimerUntilEnd > 0)
            {
                TimerUntilEnd -= Time.deltaTime;
            }
            else if (TimerUntilEnd <= 0.0)
            {
                TimerUntilEnd = 5.0f;
                Burned = false;
            }
        }
        else if (Frozen == true)
        {
            if (TimerUntilEnd > 0)
            {
                TimerUntilEnd -= Time.deltaTime;
            }
            else if (TimerUntilEnd <= 0.0)
            {
                TimerUntilEnd = 5.0f;
                Frozen = false;
            }
        }
        else if (Stunned == true)
        {
            if (TimerUntilEnd > 0)
            {
                TimerUntilEnd -= Time.deltaTime;
            }
            else if (TimerUntilEnd <= 0.0)
            {
                TimerUntilEnd = 5.0f;
                Stunned = false;
            }
        }
    }
}
