using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations.Rigging;

public class PlayerAiming : MonoBehaviour
{
    public float turnspeed = 15f;
    public Rig aimLayer;
    float aimDuration = 0.2f;
    public bool aimed = false;

    Camera MainCam;
    RayCastWeapon weapon;
    // Start is called before the first frame update
    void Start()
    {
        MainCam = Camera.main;
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
        weapon = GetComponentInChildren<RayCastWeapon>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float yawCam = MainCam.transform.rotation.eulerAngles.y;
        transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.Euler(0, yawCam, 0), turnspeed * Time.fixedDeltaTime);
    }
    private void LateUpdate()
    {
        if (Input.GetMouseButton(1))
        {
            aimLayer.weight += Time.deltaTime / aimDuration;
        }
        else
        {
            aimLayer.weight -= Time.deltaTime / aimDuration;
        }

        if (aimLayer.weight == 1)
        {
            aimed = true;
        }
        else
        {
            aimed = false;
        }
        if(Input.GetMouseButtonDown(0)&&aimed)
        {
            weapon.StartFiring();
        }
        if(Input.GetMouseButtonUp(0)||aimed == false)
        {
            weapon.StopFiring();
        }
    }
}
