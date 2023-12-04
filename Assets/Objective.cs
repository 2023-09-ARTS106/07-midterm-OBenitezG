using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Objective : MonoBehaviour
{
    Animator animator;

    ValvePickUp vpuScript;

    void Start()
    {
        animator = GetComponent<Animator>();

        vpuScript = GameObject.Find("Valve PickUp").GetComponent<ValvePickUp>();

    }

    void Update()
    {
        if (vpuScript.isValvePickedUp())
        {
            animator.SetBool("changeObjective", true);
        }
    }
}
