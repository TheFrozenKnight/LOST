using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayCastWeapon : MonoBehaviour
{
    public ParticleSystem[] muzzleFlash;
    public ParticleSystem hitEffect;
    public Transform raycastOrigin;
    public Transform raycastDestination;
    public AudioSource audioSource;
    
    public bool isFiring = false;
    public float range = 10f;

    Ray ray;
    RaycastHit hitInfo;
    public void StartFiring()
    {
        isFiring = true;
        fireBullet();
    }
    public void StopFiring()
    {
        isFiring = false;
    }
    private void fireBullet()
    {
        foreach (var partical in muzzleFlash)
        {
            partical.Emit(1);
        }
        audioSource.Play();
        Physics.Raycast(raycastOrigin.position, raycastDestination.position - raycastOrigin.position, out RaycastHit hitInfo, range); 
    }
        //if (Physics.Raycast(raycastOrigin.position, raycastDestination.position - raycastOrigin.position, out hitInfo, range))
        //{
            //hitEffect.transform.position = hitInfo.point;
            //hitInfo.transform.forward = hitInfo.normal;
            //hitEffect.Emit(1);
       // }
   
}
