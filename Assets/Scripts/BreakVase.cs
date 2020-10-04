using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreakVase : MonoBehaviour
{
    [SerializeField] private GameObject vase;
    [SerializeField] private AudioClip clip;

    private Rigidbody[] rigidbodies;

    private bool isBroken = false;

    private void OnTriggerEnter(Collider other)
    {
        if (!isBroken)
        {
            rigidbodies = vase.gameObject.GetComponentsInChildren<Rigidbody>();

            foreach (Rigidbody rb in rigidbodies)
            {
                rb.isKinematic = false;
            }

            isBroken = true;

            var objectController = vase.gameObject.GetComponent<ObjectController>();

            if (objectController != null)
            {
                objectController.SetExtraInfo("A now broken vase");
                objectController.SetAudioClip(clip);
            }

        }

        
    }
}
