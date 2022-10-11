using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetTracker : MonoBehaviour
 {
    [Tooltip("The target to be tarcked.")]
    [SerializeField] private Transform target;
    [Tooltip("Theoffset position from the target.")]
    [SerializeField] private Vector3 positionOffset;

    // <summary>
    // lateUpdate is called once per frame
    // </summary>
    void LateUpdate()
    {
        transform.position = target.position + positionOffset;   
    }
}
