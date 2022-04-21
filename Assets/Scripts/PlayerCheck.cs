using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCheck : MonoBehaviour
{
    [SerializeField] private StartTimeline StartTimeline;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Stairs"))
        {
            StartTimeline.GetBoolCheck(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Stairs"))
        {
            StartTimeline.GetBoolCheck(false);
        }
    }
}
