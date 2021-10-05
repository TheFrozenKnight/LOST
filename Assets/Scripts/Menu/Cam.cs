using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cam : MonoBehaviour
{
    float rotY;
    void FixedUpdate()
    {
        rotY -= .075f;
        transform.rotation = Quaternion.Euler(0, rotY, 0);
    }
}
