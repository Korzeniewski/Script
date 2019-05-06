using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraControler : MonoBehaviour
{
    public Transform target;
    public float cameraSmooth = 0.125f;
    public Vector3 offset = new Vector3(0, 0, -6.3f);
    void Start()
    {
        
    }

   
    void Update()
    {
        Vector3 designerPosition = target.transform.position + offset;
        transform.position = Vector3.Lerp(transform.position, designerPosition, cameraSmooth);
    }
}
