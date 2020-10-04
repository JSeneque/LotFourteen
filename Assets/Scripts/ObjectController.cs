using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ObjectController : MonoBehaviour
{
    [SerializeField] private string objectName;
    [TextArea] [SerializeField] private string extraInfo;
    [SerializeField] private AudioSource audioSource;

    [SerializeField] private InspectController inspectController;

    public void ShowObjectName()
    {
        inspectController.ShowName(objectName);
    }

    public void HideObjectName()
    {
        inspectController.HideName();
    }

    public void ShowExtraInfo()
    {
        inspectController.ShowInfo(extraInfo);
        audioSource.Play();
    }

    public void SetExtraInfo (string text)
    {
        extraInfo = text;
    }

    public void SetAudioClip(AudioClip clip)
    {
        audioSource.clip = clip;
    }
}
