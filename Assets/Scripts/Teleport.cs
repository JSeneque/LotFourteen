using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    [SerializeField]
    private float offset = 7.75f;

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        

        Vector3 currentPos = other.transform.position;
        Debug.Log("Before: " + currentPos);

        other.transform.position = new Vector3(currentPos.x, currentPos.y + offset, currentPos.z);
        Debug.Log("After: " + other.transform.position);
    }
}
