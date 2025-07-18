using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clock : MonoBehaviour
{
    [SerializeField]
    private GameObject secondsHandle, minutesHandle, hoursHandle;
    private float secondsMultiplier = 1f;
    private int inGameSeconds;
    private int timeAtStart = 10000;

    void Update()
    {
        inGameSeconds = Mathf.RoundToInt(Time.time * secondsMultiplier) + timeAtStart;
        secondsHandle.transform.localRotation = Quaternion.Euler(inGameSeconds * 360 / 60, 0, -90);
        minutesHandle.transform.localRotation = Quaternion.Euler(inGameSeconds * 360 / 3600, 0, -90);
        hoursHandle.transform.localRotation = Quaternion.Euler(inGameSeconds * 360 / 43200, 0, -90);
    }
}