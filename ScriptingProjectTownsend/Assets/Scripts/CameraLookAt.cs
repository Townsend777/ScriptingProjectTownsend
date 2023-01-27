using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraLookAt : MonoBehaviour
{
    public Transform target; 

    // Start is called before the first frame update
    void Update()
    {
        transform.LookAt(target);
    }
}
