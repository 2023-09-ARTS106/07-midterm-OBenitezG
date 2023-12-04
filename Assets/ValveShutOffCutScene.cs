using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ValveShutOffCutScene : MonoBehaviour
{
    Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    private void OnTriggerStay(Collider other)
    {

        if (Input.GetKeyDown("f"))
        {
            animator.SetBool("Valve Shut Off", true);
        }
    }
}
