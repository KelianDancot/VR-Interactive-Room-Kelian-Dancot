using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateYaxes : MonoBehaviour
{
    public float speed = 100f;

    void Update()
    {
        transform.rotation *= Quaternion.Euler(0, speed * Time.deltaTime, 0);
    }
}
