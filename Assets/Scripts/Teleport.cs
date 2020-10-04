using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    [SerializeField]
    private float offset = 7.75f;
    [SerializeField]
    private Transform location;

    private void OnTriggerEnter(Collider other)
    {
        
        if(location == null)
        {
            Vector3 currentPos = other.transform.position;
            other.transform.position = new Vector3(currentPos.x, currentPos.y + offset, currentPos.z);
        }
        else
        {
            other.transform.position = location.position;
        }
        
    }
}
