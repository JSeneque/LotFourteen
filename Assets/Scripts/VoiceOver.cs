using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VoiceOver : MonoBehaviour
{
    [SerializeField] private AudioSource  voiceOver;
    private void OnTriggerEnter(Collider other)
    {
        voiceOver.Play();
    }


}
