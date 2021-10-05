using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ship : MonoBehaviour
{
    float rotY = -60;
    void Update()
    {
        rotY += .075f;
        transform.rotation = Quaternion.Euler(0, rotY, 0);
    }
}
