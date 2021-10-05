using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Icon : MonoBehaviour
{
    float rotY;
    void FixedUpdate()
    {
        rotY -= .75f;
        transform.rotation = Quaternion.Euler(0, rotY, 0);
    }
}
