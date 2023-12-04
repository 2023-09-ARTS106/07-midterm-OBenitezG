using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ValveShutOffCutScene : MonoBehaviour
{
    Animator animator;

    public AudioClip squeek;
    public AudioSource audioS;

    ValvePickUp vpuScript;

    void Start()
    {
        animator = GetComponent<Animator>();

        vpuScript = GameObject.Find("Valve PickUp").GetComponent<ValvePickUp>();
        
    }

    private void OnTriggerStay(Collider other)
    {

        if (Input.GetKeyDown("f") && vpuScript.isValvePickedUp())
        {
            animator.SetBool("Valve Shut Off", true);
            audioS.PlayOneShot(squeek);
        }
    }
}
