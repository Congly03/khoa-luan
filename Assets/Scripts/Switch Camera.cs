using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchCamera : MonoBehaviour
{
   [Header("Camera to Assign")]
   public GameObject AimCam;
   public GameObject Aimcanvas;
   public GameObject ThirdPersonCam;
   public GameObject ThirdPersonCanvas;

   [Header("Camera Animator")]
   public Animator animator;

       private void Update()
    {
        if(Input.GetButton("Fire2") && Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            animator.SetBool("Idle", false);
            animator.SetBool("IdleAim", true);
            animator.SetBool("FireWalk", true);
            animator.SetBool("Walk", true);

            ThirdPersonCam.SetActive(false);
            ThirdPersonCanvas.SetActive(false);
            AimCam.SetActive(true);
            Aimcanvas.SetActive(true);
        }
        else if(Input.GetButton("Fire2"))
        {
            animator.SetBool("Idle", false);
            animator.SetBool("IdleAim", true);
            animator.SetBool("FireWalk", false);
            animator.SetBool("Walk", false);

            ThirdPersonCam.SetActive(false);
            ThirdPersonCanvas.SetActive(false);
            AimCam.SetActive(true);
            Aimcanvas.SetActive(true);
        }
        else
        {   
            animator.SetBool("Idle", true);
            animator.SetBool("IdleAim", false);
            animator.SetBool("FireWalk", false);

            ThirdPersonCam.SetActive(true);
            ThirdPersonCanvas.SetActive(true);
            AimCam.SetActive(false);
            Aimcanvas.SetActive(false);
        }
    }
}
