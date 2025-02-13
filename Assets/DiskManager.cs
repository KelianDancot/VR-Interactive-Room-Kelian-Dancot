using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class DiskManager : MonoBehaviour
{
    public float speed = 1f;

    public void PlayDisk(SelectEnterEventArgs disk)
    {
        disk.interactableObject.transform.GetComponent<AudioSource>().volume = 1;
    }

    public void StopDisk(SelectExitEventArgs disk)
    {
        disk.interactableObject.transform.GetComponent<AudioSource>().volume = 0;
    }
}