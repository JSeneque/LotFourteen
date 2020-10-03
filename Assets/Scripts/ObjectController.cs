﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ObjectController : MonoBehaviour
{
    [SerializeField] private string objectName;
    [TextArea] [SerializeField] private string extraInfo;

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
    }
}
